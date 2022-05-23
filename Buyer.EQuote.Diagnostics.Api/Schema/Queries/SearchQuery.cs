using Buyer.EQuote.Diagnostics.Api.Schema.Types;
using Buyer.EQuote.Diagnostics.Domain.Services;
using GraphQL;
using GraphQL.Types;

namespace Buyer.EQuote.Diagnostics.Api.Schema.Queries
{
    public class SearchQuery : ObjectGraphType
    {
        private readonly IOstSettingsService _ostSettingsService;

        public SearchQuery(IOstSettingsService ostSettingsService)
        {
            _ostSettingsService = ostSettingsService;

            this.FieldQuery();
        }

        private void FieldQuery()
        {
            Field<ProductsType>(name: "Products", arguments:
            new QueryArguments(new QueryArgument<StringGraphType> { Name = "id" }),
            resolve: context => _ostSettingsService.OstSettingsForRCAsync(context.GetArgument<string>("id")));
        }

    }
}
