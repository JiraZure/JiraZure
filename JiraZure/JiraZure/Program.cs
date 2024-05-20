using JiraZure.Services.Implementations;
using JiraZure.Services.Interfaces;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IServerConfiguration, NoDatabase>();
// Add services to the container
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var setup = new Setup()
setup.AddOpenTelemetry(ref builder );


setup.test("s");


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
