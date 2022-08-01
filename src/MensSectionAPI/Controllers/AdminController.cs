using Microsoft.AspNetCore.Mvc;

namespace MensSectionAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AdminController : ControllerBase
{

    
    private readonly ILogger<WeatherForecastController> _logger;

    public AdminController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
}