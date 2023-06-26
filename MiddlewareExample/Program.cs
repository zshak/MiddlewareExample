using MiddlewareExample;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<AuthenticationMiddleware>();
var app = builder.Build();
app.UseMiddleware<AuthenticationMiddleware>();
//app.MapGet("/", () => "Hello World!");

app.Run();
