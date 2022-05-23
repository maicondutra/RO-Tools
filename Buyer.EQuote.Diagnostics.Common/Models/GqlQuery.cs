using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Common.Models
{
    [ExcludeFromCodeCoverage]
    public class GqlQuery
    {
        public string Operation { get; set; }
        public string QueryNamed { get; set; }
        public string Query { get; set; }
        public Dictionary<string, object> Variables { get; set; }
    }
}
