using JiraZure.Services.Interfaces;
using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;

namespace JiraZure.Services.Implementations
{
    //IHostedService is a built-in interface in .NET Core that allows you to run background tasks in a hosted service.
    public class HealthCheckService : IHostedService, IDisposable
    {
        private Timer? _timer;
        private readonly Meter _meter;
        private readonly Counter<int> _serverUpCounter;
        private readonly Counter<int> _serverDownCounter;
        private readonly Histogram<double> _latencyHistogram;
        private readonly IServerConfiguration _serverConfiguration;
        private readonly string _serverAddress = "your-server-address";
        private readonly int _pingTimeout = 1000; // 1 second

        public HealthCheckService(IServerConfiguration serverConfiguration)
        {
            //OpenTelemetry.Metrics  collect and export metrics
            _meter = new Meter("HealthCheckMeter");
            _serverUpCounter = _meter.CreateCounter<int>("server_up_count");
            _serverDownCounter = _meter.CreateCounter<int>("server_down_count");
            _latencyHistogram = _meter.CreateHistogram<double>("server_latency", "ms");
            _serverConfiguration = serverConfiguration;

        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(PingAdress, null, TimeSpan.Zero, TimeSpan.FromSeconds(60)); // check every 30 seconds
            return Task.CompletedTask;
        }

        private void PingAdress(object state)
        {
            Task.Run(async () =>
            {
                using (var ping = new Ping())
                {
                    try
                    {
                        var reply = await ping.SendPingAsync(_serverAddress, _pingTimeout);
                        if (reply.Status == IPStatus.Success)
                        {
                            _serverUpCounter.Add(1);
                            _latencyHistogram.Record(reply.RoundtripTime); // Record latency

                        }
                        else
                        {
                            //TODO: check Roundtrip if fail to make the same in Exception
                            _latencyHistogram.Record(reply.RoundtripTime); // Record latency
                            _serverDownCounter.Add(1);
                        }
                    }
                    catch (Exception)
                    {
                        _latencyHistogram.Record(-1); // Record latency
                        _serverDownCounter.Add(1);
                    }
                }
            });
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            if (_timer != null)
            {
                _timer.Dispose();
            }
        }
    }
}