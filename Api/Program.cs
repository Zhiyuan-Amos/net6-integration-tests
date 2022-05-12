using Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IDummyHelper, DummyHelper>();

var app = builder.Build();
app.MapControllers();

app.Run();

public partial class Program { }
