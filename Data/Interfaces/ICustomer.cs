using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface ICustomer : IUser<Customer>
    {
       

        public void AddOrder(Order order, Customer customer);
    }
}
