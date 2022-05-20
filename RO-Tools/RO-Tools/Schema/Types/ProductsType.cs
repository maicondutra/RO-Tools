using GraphQL.Types;
using RO_Tools.Models;

namespace RO_Tools.Schema.Types
{
    public class ProductsType : ObjectGraphType<Products>
    {
        public ProductsType()
        {
            this.Name = "Products";
            Field(_ => _.id).Description("Products id");
            Field(_ => _.price).Description("Price");
            Field(_ => _.noGop).Description("NoGop");
            Field(_ => _.name).Description("Name");

        }
    }
}
