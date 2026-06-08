var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola Mundo desde Azure! Usando deplo automatico");

app.MapGet("/health", () => Results.Ok("OK"));

app.Run();
