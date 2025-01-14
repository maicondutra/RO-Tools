﻿using Buyer.EQuote.Diagnostics.Common.Models;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Buyer.EQuote.Diagnostics.Api.Controllers
{
    [ExcludeFromCodeCoverage]
    [ApiController, Route("api/diagnostics/gql")]
    public class DiagnosticsGQLController : ControllerBase
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;
        private readonly IConfiguration _configuration;

        public DiagnosticsGQLController(
            ISchema schema, 
            IDocumentExecuter executer,
            IConfiguration configuration)
        {
            _schema = schema;
            _executer = executer;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ExecutionResult> PostQuery(GqlQuery query)
        {
            var result = await _executer.ExecuteAsync(_ => {
                _.Schema = _schema;
                _.Query = query.Query;
                _.Inputs = query.Variables?.ToInputs();
            });
            return result;
        }
    }
}
