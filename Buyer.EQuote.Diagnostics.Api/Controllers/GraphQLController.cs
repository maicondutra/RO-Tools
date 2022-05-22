using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using RO_Tools.Models;

namespace Buyer.EQuote.Diagnostics.Api.Controllers
{
    [ApiController, Route("api/gql")]
    public class GraphQLController : ControllerBase
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;
        public GraphQLController(ISchema schema, IDocumentExecuter executer)
        {
            _schema = schema;
            _executer = executer;
        }

        [HttpPost]
        public async Task<ExecutionResult> Post(GqlQuery query)
        {
            var result = await _executer.ExecuteAsync(_ => {
                _.Schema = _schema;
                _.Query = query.Query;
                _.Inputs = query.Vars?.ToInputs();
            });
            return result;
        }
    }
}
