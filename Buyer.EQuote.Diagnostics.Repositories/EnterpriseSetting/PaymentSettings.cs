using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Repositories.EnterpriseSetting
{
    [ExcludeFromCodeCoverage]
    public class PaymentSettings
    {
        public List<PaymentOption> PaymentOptions { get; set; }
        public List<PaymentCategory> PaymentCategories { get; set; }
        public bool? EnableMultipleCreditCards { get; set; }
        public string DefaultPaymentCategoryName { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class PaymentOption
    {
        public string PayCode { get; set; }
        public int DisplayOrder { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool? IsDefaultPaymentMethod { get; set; }
        public double? MaxOrderAmount { get; set; }
        public double? MinOrderAmount { get; set; }
        public string CombinesWith { get; set; }
        public string PaymentOptionLabel { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class PaymentCategory
    {
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public bool isPurchaseOrderRequired { get; set; }
        public bool isPurchaseOrderVisible { get; set; }
        public int? DisplayOrder { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class PurchaseOrderNumberSettings
    {
        public string Code { get; set; }
        public bool Required { get; set; }
        public bool Visible { get; set; }
    }
}
