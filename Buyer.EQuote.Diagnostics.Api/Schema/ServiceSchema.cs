using Buyer.EQuote.Diagnostics.Api.Schema.Queries;
using GQLTypes = GraphQL.Types;

namespace Buyer.EQuote.Diagnostics.Api.Schema
{
    public class ServiceSchema : GQLTypes.Schema, GQLTypes.ISchema
    {
        public ServiceSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetService<SearchQuery>();
            //Mutation = serviceProvider.GetService<MutationQuery>();
        }     
    }
}
