using GraphQL.Types;
using RO_Tools.Models;

namespace RO_Tools.Schema.Types
{
    public class OstSettingsType : ObjectGraphType<OstSettings>
    {
        public OstSettingsType()
        {
            this.Name = "OstSettings";
            Field(_ => _.Id).Description("OstSettings id");
            Field(_ => _.OfflineQuotes).Description("OfflineQuotes");
            Field(_ => _.EQuotes).Description("EQuotes");
            Field(_ => _.ProductValidation).Description("ProductValidation");
            Field(_ => _.Repricing).Description("Repricing");
            Field(_ => _.SaveTax).Description("SaveTax");
            Field(_ => _.SaveEQuotes).Description("SaveEQuotes");
            Field(_ => _.Required).Description("Required");
            Field(_ => _.Expiration).Description("Expiration");
            Field(_ => _.SendEQuotes).Description("SendEQuotes");
            Field(_ => _.Recommendations).Description("Recommendations");
            Field(_ => _.Upsell).Description("Upsell");
            Field(_ => _.BuyerTitle).Description("BuyerTitle");

        }
    }
}
