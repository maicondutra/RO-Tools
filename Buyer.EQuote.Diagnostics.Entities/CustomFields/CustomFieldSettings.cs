using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Entities.CustomFields
{
    [ExcludeFromCodeCoverage]
    public class CustomFieldSettings
    {
        public string Id { get; set; }
        public string FieldId { get; set; }
        public string FieldLabel { get; set; }
        public string FieldType { get; set; }
        public bool IsRequired { get; set; }
        public bool HasDomsMapping { get; set; }
        public string MappingType { get; set; }
        public CustomFieldSettingSupportedValues Value { get; set; }
        public CustomFieldPage Page { get; set; }
        public IList<CustomFieldSettingSupportedValues> Values { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class CustomFieldSettingSupportedValues
    {
        public bool IsDefault { get; set; }
        public string prePopulateValue { get; set; }
    }
}
