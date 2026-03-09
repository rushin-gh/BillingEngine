using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PolicyBillingIntegrationAPIs.Controllers
{
    [ApiController]
    public class AppController : ControllerBase
    {
        [HttpGet("health")]
        public string ping() =>  "App is running successfully";
    }
}
