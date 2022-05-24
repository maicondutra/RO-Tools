using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Common.Models
{
    [ExcludeFromCodeCoverage]
    public class BridgeContext
    {
        public bool IsGlobalPortal { get; set; }
        public string StoreId { get; set; }
        public string AccessGroup { get; set; }
        public string SegmentCode { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCode { get; set; }
        public string RegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public string DisplayCulture { get; set; }
        public string ProfileId { get; set; }
        public string SegmentDisplayName { get; set; }
        public string InstanceId { get; set; }
        public string AccessGroupName { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public AccessGroupType AccessGroupType { get; set; }
        public string UserName { get; set; }
        public string CatalogCode { get; set; }
        public string SalesSegment { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public enum AccessGroupType
    {
        Unknown,
        Premier,
        Partner,
        Public,
        BusinessToBusiness,
        Authenticated,
    }
}
