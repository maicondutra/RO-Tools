namespace RO_Tools.Models
{
    public class OstSettings
    {
        public Guid Id { get; set; }
        public bool OfflineQuotes { get; set; }
        public bool EQuotes { get; set; }
        public bool ProductValidation { get; set; }
        public bool Repricing { get; set; }
        public bool SaveTax { get; set; }
        public string SaveEQuotes { get; set; }
        public string Required { get; set; }
        public int Expiration { get; set; }
        public bool SendEQuotes { get; set; }
        public bool Recommendations { get; set; }
        public bool Upsell { get; set; }
        public string BuyerTitle { get; set; }
    }
}
