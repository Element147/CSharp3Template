var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () => "test");
app.MapGet("/czechitas", () => "czechitas");
app.MapGet("/pozdrav/{jmeno}", (string jmeno) => $"Ahoj {jmeno}");
app.MapGet("/soucet/{a}/{b}", (int a, int b) => $" Vysledek je: {a + b}");

app.Run();
