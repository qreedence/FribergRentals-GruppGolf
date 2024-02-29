using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface ICustomer : IUser<Customer>
    {
        public void Add(Customer customer);

        public void AddOrder(Order order, Customer customer);
    }
}
