using Castelom.LifeCycleExample.Interfaces;

namespace Castelom.LifeCycleExample.Services
{
    public class PriceService : IPriceService
    {
        private readonly IPurchaseOrder _purchaseOrder;

        public PriceService(IPurchaseOrder purchaseOrderService)
        {
            _purchaseOrder = purchaseOrderService;
        }

        public async Task GetPriceAsync()
        {
            /*
             *Delay represent the processing time of the GetPrice function.
             *Let supouse that PriceService needs to comunicate with other services or APIs to get info about 
             *discounts, prices, promotions... */
            await Task.Delay(10000);
            _purchaseOrder.SetPrice();

            /*
             * Represent the creation of an Invoice
             */
            Console.WriteLine("Invoice: ");
            Console.WriteLine($"Customer: {_purchaseOrder.GetCustomer()}");
            Console.WriteLine($"Order: {_purchaseOrder.GetOrderNumber()}");
            Console.WriteLine($"Price: {_purchaseOrder.GetPrice()}");
        }
    }
}
