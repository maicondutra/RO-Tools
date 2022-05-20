using RO_Tools.Models;

namespace RO_Tools.Repository
{
    public class OstSettingsRepository
    {
        private readonly List<OstSettings> _OstSettings;
        public OstSettingsRepository()
        {
            _OstSettings = new List<OstSettings>();

            _OstSettings.Add(new OstSettings
            {
                Id = Guid.NewGuid(),
                BuyerTitle = "Authorized Buyer",
                EQuotes = true,
                Expiration = 15,
                OfflineQuotes = false,
                ProductValidation = true,
                Recommendations = true,
                Repricing = true,
                Required = "BillingAddress",
                SaveEQuotes = "ShippingAddress",
                SaveTax = true,
                SendEQuotes = false,
                Upsell = true
            });
        }

        internal List<OstSettings> OstSettingsAll() => this._OstSettings;

        internal OstSettings OstSettingsForRC(string customerSet)
        {
            throw new NotImplementedException();
        }

        internal OstSettings OstSettingsForIDRC(Guid id)
        {
            var stt = _OstSettings.Where(osts => osts.Id.Equals(id)).FirstOrDefault();
            return stt != null ? stt : null;
        }
    }
}
