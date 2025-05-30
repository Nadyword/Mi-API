var builder = WebApplication.CreateBuilder(args);
ConfigurationManager config = builder.Configuration;
builder.Services.AddControllers();

var app = builder.Build();

app.Urls.Add($"http://localhost:{config["Environment:Port"]}");
app.UseAuthorization();
app.MapControllers();
app.Run();