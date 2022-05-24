using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Repositories.EnterpriseSetting
{
    [ExcludeFromCodeCoverage]
    public class PricingSettings
    {
        public bool ShowFullCatalogDiscount { get; set; }
        public bool ShowSNPDiscount { get; set; }
        public bool ShowStandardConfigDiscount { get; set; }
    }
}
