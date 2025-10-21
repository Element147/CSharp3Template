using ToDoList.Persistence;
var builder = WebApplication.CreateBuilder(args);
{
    // Configure DI
    builder.Services.AddControllers();
    builder.Services.AddDbContext<ToDoItemsContext>();
}
var app = builder.Build();
{
    // configure Middleware (Http request pipeline)
    app.MapControllers();
}
app.Run();
