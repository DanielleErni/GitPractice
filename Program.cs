var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/kape", ()=> "hello ang tapang ng kape");

app.Run();
