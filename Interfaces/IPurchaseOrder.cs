namespace Castelom.LifeCycleExample.Interfaces
{
    public interface IPurchaseOrder
    {
        public void AssignCustomer(string customerName);
        public void SetPrice();
        public string GetCustomer();
        public Guid GetOrderNumber();
        public int GetPrice();
    }
}
