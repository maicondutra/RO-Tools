using GraphQL;
using GraphQL.Types;
using RO_Tools.Schema.Types;
using RO_Tools.Services;

namespace RO_Tools.Schema.Queries
{
    public class SearchQuery : ObjectGraphType
    {
        public SearchQuery(OstSettingsService _ostSettingsService)
        {
            Field<ListGraphType<OstSettingsType>>(name: "OstSettingsAll", resolve: context => _ostSettingsService.OstSettingsAll());

            Field<OstSettingsType>(name: "OstSettings", arguments:
            new QueryArguments(new QueryArgument<GuidGraphType> { Name = "id" }),
            resolve: context => _ostSettingsService.OstSettingsForIDRC(context.GetArgument<Guid>("id")));

            Field<ProductsType>(name: "Products", arguments:
            new QueryArguments(new QueryArgument<StringGraphType> { Name = "id" }),
            resolve: context => _ostSettingsService.OstSettingsForRC(context.GetArgument<string>("id")));
        }
    }
}
