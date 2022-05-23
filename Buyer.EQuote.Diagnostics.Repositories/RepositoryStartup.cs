using Buyer.EQuote.Diagnostics.Repositories.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Repositories
{
    [ExcludeFromCodeCoverage]
    public static class RepositoryStartup
    {
        public static void ConfigureRepositoryServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient();

            services.AddHeaderPropagation(options =>
            {
                options.Headers.Add("Cookie");
            });

            services.AddSingleton<IOstSettingsRepository, OstSettingsRepository>();
        }
    }
}