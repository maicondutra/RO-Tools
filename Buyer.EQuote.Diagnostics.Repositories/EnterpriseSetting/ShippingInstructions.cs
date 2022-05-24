using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Repositories.EnterpriseSetting
{
    [ExcludeFromCodeCoverage]
    public class ShippingInstructions
    {
        public ShippingInstructions()
        {
            Mode = DisplayMode.Optional;
            PrepopulationEnabled = false;
            HelpTextEnabled = false;
        }

        public DisplayMode Mode { get; set; }

        public bool PrepopulationEnabled { get; set; }

        public bool HelpTextEnabled { get; set; }
    }
}
