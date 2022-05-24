using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Repositories.EnterpriseSetting
{
    [ExcludeFromCodeCoverage]
    public class TaxExemption
    {
        public bool Enabled { get; set; }
        public bool DefaultStatus { get; set; }
    }
}
