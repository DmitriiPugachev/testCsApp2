using testCsApp2.Application.Services.Interfaces;

namespace testCsApp2.Application.Services
{
    public class HealthService : IHealthService
    {
        public bool GetHealth()
        {
            return true;
        }
    }
}