using testCsApp2.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace testCsApp2.Api.Controllers
{   
    [ApiController]
    [Route("api/v1/health")]
    public class HealthController : ControllerBase
    {
        private readonly IHealthService _healthService;

        public HealthController(IHealthService healthService)
        {
            _healthService = healthService;
        }

        [HttpGet]
        public bool GetHealthStatus()
        {
            return _healthService.GetHealth();
        }
    }
}