using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Repositories.EnterpriseSetting
{
    [ExcludeFromCodeCoverage]
    public class EquoteSettings
    {
        public bool EnableEquotes { get; set; }
        public int EquoteExpiryDays { get; set; }
        public bool EnableEquoteRepricing { get; set; }
        public int RfqExpiryDays { get; set; }
        public bool DisplaySaveEquoteButton { get; set; }
        public bool EnableOfflineQuotes { get; set; }
    }
}
