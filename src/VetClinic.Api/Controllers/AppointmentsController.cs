using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/appointments")]
public class AppointmentsController : ControllerBase { [HttpGet] public IActionResult Get() => Ok(); }