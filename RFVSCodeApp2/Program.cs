var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!  This is my 2nd .NET app from VS Code.  Edited from within GitHub.  ");

app.Run();
