var builder = WebApplication.CreateBuilder(args);
{
    // Configure DI
    builder.Services.AddControllers();
}
var app = builder.Build();
{
    // configure Middleware (Http request pipeline)
    app.MapControllers();
}

/*
app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () => "test");
app.MapGet("/czechitas", () => "czechitas");
app.MapGet("/pozdrav/{jmeno}", (string jmeno) => $"Ahoj {jmeno}");
app.MapGet("/soucet/{a}/{b}", (int a, int b) => $" Vysledek je: {a + b}");
app.MapGet("/nazdarsvete", () => "Ahoj světe!");
*/

app.Run();
