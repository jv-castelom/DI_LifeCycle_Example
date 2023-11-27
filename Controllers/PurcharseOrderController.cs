using Castelom.LifeCycleExample.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Castelom.LifeCycleExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurcharseOrderController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public PurcharseOrderController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet("{CustomerName}/GetInvoice")]
        public async Task<IActionResult> GetInvoice(string CustomerName)
        {
            await _applicationService.GetCustomerAsync(CustomerName);
            await _applicationService.GetPriceAsync();
            return Ok();
        }
    }
}