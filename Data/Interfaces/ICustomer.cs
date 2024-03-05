using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface ICustomer : IUser<Customer>
    {
        public Task AddOrderAsync(Customer customer, Order order);
    }
}
