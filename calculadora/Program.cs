var builder = WebApplication.CreateBuilder(args);


builder.WebHost.UseUrls("http://localhost:8000");

var app = builder.Build();

app.MapGet("/", () => "Calculadora");
app.MapGet("/soma", () => new {mensagem="10 + 5" });
app.MapGet("/subtracao", () => new {mensagem="10 - 6" });
app.MapGet("/multiplicacao", () => new {mensagem="10 * 7" });
app.MapGet("/divisao", () => new {mensagem="10  / 8" });

app.Run();