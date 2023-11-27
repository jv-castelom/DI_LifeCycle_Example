namespace Castelom.LifeCycleExample.Interfaces
{
    public interface IApplicationService
    {
        public Task GetCustomerAsync(string customerName);
        public Task GetPriceAsync();
    }
}
