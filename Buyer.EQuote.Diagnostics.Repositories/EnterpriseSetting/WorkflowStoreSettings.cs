using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Repositories.EnterpriseSetting
{
    [ExcludeFromCodeCoverage]
    public class WorkflowStoreSettings
    {
        public WorkflowStoreSettings()
        {
            BillingInformation = DisplayMode.Optional;
            ShippingInformation = DisplayMode.Optional;
            MailingInformation = DisplayMode.Off;
            PaymentInformation = DisplayMode.Optional;
            ContactInformation = DisplayMode.Optional;
        }

        public DisplayMode BillingInformation { get; set; }
        public DisplayMode ShippingInformation { get; set; }
        public DisplayMode MailingInformation { get; set; }
        public DisplayMode PaymentInformation { get; set; }
        public DisplayMode ContactInformation { get; set; }

        public bool ShowBillingInformation
        {
            get
            {
                return BillingInformation != DisplayMode.Off;
            }
        }

        public bool ShowShippingInformation
        {
            get
            {
                return ShippingInformation != DisplayMode.Off;
            }
        }

        public bool ShowMailingInformation
        {
            get
            {
                return MailingInformation != DisplayMode.Off;
            }
        }

        public bool ShowPaymentInformation
        {
            get
            {
                return PaymentInformation != DisplayMode.Off;
            }
        }
    }
}
