using JiraZure.Services.Implementations;
using JiraZure.Services.Interfaces;



var builder = WebApplication.CreateBuilder(args);
// Add services to the container
builder.Services.AddScoped<IServerConfiguration, NoDatabase>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHostedService<HealthCheckService>();

var setup = new Setup(new NoDatabase());
setup.AddOpenTelemetry(ref builder );



var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.Run();
