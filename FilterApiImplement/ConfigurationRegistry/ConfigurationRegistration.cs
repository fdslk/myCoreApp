using FilterApiImplement.Configuration;
using FilterApiImplement.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterApiImplement.ConfigurationRegistry
{
    public static class ConfigurationRegistration
    {
        public static IServiceCollection AddConfigurations(
            this IServiceCollection configurations,
            IConfiguration configuration)
        {
            configurations.Configure<EmailConfigure>(configuration.GetSection("Email"));
            configurations.Configure<PositionOptions>(configuration.GetSection("Position"));
            return configurations;
        }
    }
}