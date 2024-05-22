using Microsoft.AspNetCore.Mvc;
using UdpDbModels;

namespace TelemetryApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LapDataController(ForzaTelemetryContext context) : ControllerBase {
    [HttpGet]
    public IActionResult Get() => Ok(context.LapData.ToList());

    [HttpPost]
    public IActionResult Post([FromBody] LapData lapData) {
        context.Add(lapData);
        context.SaveChanges();

        return Ok();
    }
}