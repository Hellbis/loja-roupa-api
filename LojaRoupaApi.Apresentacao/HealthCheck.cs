using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace LojaRoupaApi.Apresentacao
{
    public class HealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
