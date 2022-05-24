using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Buyer.EQuote.Diagnostics.Entities.CustomFields
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomFieldPage
    {
        [Description("Unknown")]
        Unknown = 0,

        [Description("PC")]
        PaymentProcurementCard = 1,

        [Description("Contact")]
        Contact = 2,

        [Description("Shipping")]
        Shipping = 3,

        [Description("Billing")]
        Billing = 4,

        [Description("Equotes")]
        Equotes = 5,

        [Description("CC")]
        PaymentCreditCard = 6,

        [Description("TP")]
        PaymentFloorPlanning = 7,

        [Description("BL")]
        PaymentBusinessLease = 8,

        [Description("PO")]
        PaymentPurchaseOrder = 9,

        [Description("CH")]
        PaymentCheque = 10,

        [Description("PP")]
        PaymentAccountPayment = 11,

        [Description("WT")]
        PaymentWireTransfer = 12,

        [Description("DF")]
        PaymentVariableFinancing = 13,

        [Description("MA")]
        PaymentMandatAdministratif = 14,

        [Description("CH")]
        PaymentBoletoBancario = 15,

        [Description("CASH")]
        PaymentDirectDeposit = 16,

        [Description("JL")]
        PaymentOrixLeasing = 17,

        [Description("SC")]
        PaymentSupplierCard = 18,

        [Description("DC")]
        PaymentDirectCreditConsumer = 19,

        [Description("GL")]
        PaymentGovernmentLease = 20
    }
}
