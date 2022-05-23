using Buyer.EQuote.Diagnostics.Entities.Models;
using GraphQL.Types;

namespace Buyer.EQuote.Diagnostics.Api.Schema.Types
{
    public class ProductsType : ObjectGraphType<Products>
    {
        public ProductsType()
        {
            this.Name = "Products";
            Field(_ => _.Id).Description("Products id");
            Field(_ => _.Price).Description("Price");
            Field(_ => _.NoGop).Description("NoGop");
            Field(_ => _.Name).Description("Name");
        }
    }
}
