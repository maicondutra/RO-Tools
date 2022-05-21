using RO_Tools.Schema.Queries;
using GQLTypes = GraphQL.Types;

namespace RO_Tools.Schema
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
