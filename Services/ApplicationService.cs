using Castelom.LifeCycleExample.Interfaces;

namespace Castelom.LifeCycleExample.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IPriceService _priceService;
        private readonly ICustomerService _customerService;
        
        public ApplicationService(IPriceService priceService, ICustomerService customerService) 
        {  
            _priceService = priceService;
            _customerService = customerService;
        }

        public async Task GetCustomerAsync(string customerName)
        {
            await _customerService.AssignCustomerAsync(customerName);
        }

        public async Task GetPriceAsync()
        {
            await _priceService.GetPriceAsync();
        }
    }
}
