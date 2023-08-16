namespace testCsApp2.Api.Controllers
{   
    [ApiController]
    [Route("api/v1/health")]
    public class HealthController : BaseController
    {
        private readonly HealthService _healthService;

        public HealthController(IHealthService _healthService)
        {
            _healthService = _healthService;
        }

        [HttpGet]
        public static bool GetHealthStatus(HealthService _healthService)
        {
            return _healthService.GetHealth()
        }
    }
}