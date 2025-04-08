var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles(); //Se puede utilizar archivos estaticos javaScript, csss, html
//app.MapControllers();
//app.Run();
app.MapGet("/", async context =>
{
    await context.Response.SendFileAsync("wwwroot/index.html");
});

app.Run();






