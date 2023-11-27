using Castelom.LifeCycleExample.Interfaces;

namespace Castelom.LifeCycleExample.Services
{
    public class CustomerService : ICustomerService
    {
        public IPurchaseOrder _purchaseOrder { get; set; }

        public CustomerService(IPurchaseOrder purchaseOrderService)
        {
            _purchaseOrder = purchaseOrderService;
        }

        public async Task AssignCustomerAsync(string customerName)
        {
            await Task.Delay(10000);
            _purchaseOrder.AssignCustomer(customerName);
            Console.WriteLine($"Order: {_purchaseOrder.GetOrderNumber()} " +
                $"assigned to Customer: {_purchaseOrder.GetCustomer()}");
        }
    }
}
