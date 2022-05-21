using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Common
{
    [ExcludeFromCodeCoverage]
    public static class CommonStartup
    {
        public static void ConfigureCommonServices(this IServiceCollection services)
        {
            services.AddScoped();
            services.DynamicTogglesRegistry();
        }
    }
}