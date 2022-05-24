using Buyer.EQuote.Diagnostics.Entities.CustomFields;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Repositories.EnterpriseSetting
{
    [ExcludeFromCodeCoverage]
    public class EnterpriseSettings
    {
        public EquoteSettings EquoteSettings { get; set; }
        public PaymentSettings PaymentSettings { get; set; }
        public bool TaxInclusive { get; set; }
        public bool EnableShippingAndTax { get; set; }
        public string DellContractCode { get; set; }
        public string CustomerAgreementNumber { get; set; }
        public string AffinityAccountID { get; set; }
        public string CompanyNumber { get; set; }
        public string BusinessUnitId { get; set; }
        public bool EnablePartnerCustomers { get; set; }
        public bool EquotesEnabled { get; set; }
        public TaxExemption TaxExemption { get; set; }
        public bool EstimatedShipDateEnabled { get; set; }
        public bool EstimatedDeliveryDateEnabled { get; set; }
        public WorkflowStoreSettings ToQuote { get; set; }
        public WorkflowStoreSettings ToOrder { get; set; }
        public ShippingInstructions ShippingInstructions { get; set; }
        public bool CouponsEnabled { get; set; }
        public bool IsGop { get; set; }
        public bool IsMigratedToUnifiedQuote { get; set; }
        public PricingSettings PricingSettings { get; set; }
        public bool ExportComplianceEnabled { get; set; }
        public bool IsEudcEnabled { get; set; }
        public IList<CustomFieldSettings> CustomCheckoutFields { get; set; }
    }
}
