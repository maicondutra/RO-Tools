using Buyer.EQuote.Diagnostics.Domain.Services;
using Buyer.EQuote.Diagnostics.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Domain
{
    [ExcludeFromCodeCoverage]
    public static class DomainStartup
    {
        public static void ConfigureDomainServices(this IServiceCollection services, IHostEnvironment hostEnvironment, IConfiguration configuration)
        {
            //Infrastructure

            //Domain Services
            services.AddTransient<IOstSettingsService, OstSettingsService>();

            //Others
            services.ConfigureRepositoryServices(configuration);
        }
    }
}