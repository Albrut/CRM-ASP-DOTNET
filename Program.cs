using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();


[ApiController]
[Route("api/hello")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHello()
    {
        return Ok(new { message = "Hello, World!" });
    }
}


[ApiController]
[Route("api/time")]
public class TimeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetTime()
    {
        return Ok(new { time = DateTime.UtcNow });
    }
}