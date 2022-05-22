using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Buyer.EQuote.Diagnostics.Api.Controllers
{
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Route("api/diagnostics")]
    public class DiagnosticsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DiagnosticsController(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("configurations")]
        public string GetConfigurations()
        {
            StringBuilder sb = new();
            _configuration.AsEnumerable().ToList().ForEach(config => sb.AppendFormat("\"{0}\":\"{1}\"\n", config.Key, config.Value));
            return sb.ToString();
        }
    }
}
