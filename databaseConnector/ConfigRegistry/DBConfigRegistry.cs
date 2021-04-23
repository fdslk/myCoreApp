using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using databaseConnector.dbconnector;
using Microsoft.EntityFrameworkCore; 
using databaseConnector.model;

namespace databaseConnector.configregistry{
     public static class BDConfigRegistry{
         public static IServiceCollection addDBConfigure(
             this IServiceCollection services,
             IConfiguration configuration)
        {
            services.Configure<ConnectorStringOptions>(configuration.GetSection("ConnectionStrings2"));
            string connectorString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<MoiveConnector>
            (options =>
            {
                options.UseMySql(connectorString, ServerVersion.AutoDetect(connectorString));
            });
            return services;
        }
     }
 }