using FilterApiImplement.Filter;
using Microsoft.Extensions.DependencyInjection;

namespace FilterApiImplement.ConfigurationRegistry
{
    public static class FilterRegistration
    {
        public static IServiceCollection AddFilters(this IServiceCollection filters)
        {
            filters.AddScoped<ActionFilterExample>();
            filters.AddScoped<AsyncActionFilterExample>();
            filters.AddScoped<MyActionFilterAttribute>();
            filters.AddScoped<MyActionFilterAttribute2>();
            filters.AddScoped<ValidationFilterAttribute>();
            return filters;
        }
    }
}