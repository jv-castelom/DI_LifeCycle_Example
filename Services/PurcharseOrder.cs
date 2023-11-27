using Castelom.LifeCycleExample.Interfaces;

namespace Castelom.LifeCycleExample.Services
{
    public class PurcharseOrder : IPurchaseOrder
    {
        public Guid OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public int Price { get; set; }

        public PurcharseOrder() {
            OrderNumber = Guid.NewGuid();
            CustomerName = "";
        }

        public void AssignCustomer(string customerName)
        {
            
            CustomerName = customerName;
        }

        public void SetPrice()
        {
            Random rnd = new Random();
            Price = rnd.Next(100, 1000000);
        }

        public string GetCustomer()
        {
            return CustomerName;
        }

        public Guid GetOrderNumber()
        {
            return OrderNumber;
        }

        public int GetPrice()
        {
            return Price;
        }
    }
}
