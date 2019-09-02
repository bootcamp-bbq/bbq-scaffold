using bbq.Scaffold.Application.Commands;
using bbq.Scaffold.Application.Queries;
using bbq.Scaffold.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace bbq.Scaffold.Web.Controllers
{
    [Route("/api/[controller]")]
    public class QueriesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken = default)
        {
            var rq = new SampleQueryRequest();

            return await this.Mediator(rq, cancellationToken);
        }

        [HttpPost]
        public async Task<IActionResult> Command(CancellationToken cancellationToken = default)
        {
            var rq = new SampleCommandRequest();
            rq.CommandInputParam = "Sample of command...";

            return await this.Mediator(rq, cancellationToken);
        }
    }
}
