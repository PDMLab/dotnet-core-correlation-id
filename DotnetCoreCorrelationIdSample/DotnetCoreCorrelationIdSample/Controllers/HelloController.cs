using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace DotnetCoreCorrelationIdSample.Controllers
{
    public class HelloController : Controller
    {
        // GET
        [Route("api/hello")]
        public IActionResult Index()
        {
            var activity = new Activity("Http_In");
            activity.SetParentId("some-parent-id");
            activity.Start();
            var CorrelationId = activity.ParentId;
            Log.Debug($"test {CorrelationId}");
            var dependency = new SomeDependency();
            return new OkObjectResult(dependency.GetHello("World"));
        }
    }
}