using JiraZure.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OpenTelemetry;
using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace JiraZure.Services.Implementations
{
    public class Setup
    {
        private readonly ServerConfiguration _serverConfig;

        public Setup(IServerConfiguration serverConfigurator)
        {
            _serverConfig = serverConfigurator.GetServerConfiguration();
        }

        internal void AddOpenTelemetry(ref WebApplicationBuilder builder)
        {
            // Configure OpenTelemetry
            builder.Logging.ClearProviders();
            // builder.Logging.AddConsole();

            if (builder.Environment.IsDevelopment())
            {
                //do someThing later 
            }
            else
            {
                //no Console
            }


            builder.Logging.AddOpenTelemetry(options =>
            {

                    // make identifyable the service name
                options.SetResourceBuilder(
                   ResourceBuilder.CreateDefault()
                   .AddService(_serverConfig.ContainerName));
                    // This option allows the logging of the logical operation scope. 
                    // A scope is a region of code with a defined beginning and end. It can be useful in tracing the flow of the application.
                options.IncludeScopes = true;

                    // Formats the Logs
                options.IncludeFormattedMessage = true;

                    // Parse state values: This option allows the parsing of the state values in the logs. 
                    // State values are additional information that can be included in the log. Parsing them can make the log more readable.
                options.ParseStateValues = true;

                    // Add console exporter
                options.AddConsoleExporter();

                }

            );
            builder.Services.AddOpenTelemetry()
              .ConfigureResource(resource => resource.AddService(_serverConfig.ContainerName))
              // Tracing is the process of monitoring and recording the performance of a system. It's used to understand the behavior of a system and to identify performance issues.
              .WithTracing(tracing =>
              {

                  // AddAspNetCoreInstrumentation: This method adds ASP.NET Core instrumentation to the tracing. Instrumentation is the act of adding observability to your code. In this case, it's adding observability to the ASP.NET Core application.
                  tracing.AddAspNetCoreInstrumentation();
                  tracing.AddConsoleExporter();
              })
              // Metrics  are numerical values that can be used to understand the behavior of a system.
              .WithMetrics(metrics =>
              {
                  metrics.AddAspNetCoreInstrumentation();
                  metrics.AddConsoleExporter();
              });

            // Additional configuration for HealthCheck metrics
            builder.Services.AddOpenTelemetry()
              .ConfigureResource(resource => resource.AddService("HealthCheck"))
              .WithMetrics(metrics =>
              {
                  metrics.AddMeter("HealthCheckMeter");
                  metrics.AddConsoleExporter();
              });
        }

        internal void CheckServerConnection()
        {
            // Implement server connection check logic here
        }
    }
}
