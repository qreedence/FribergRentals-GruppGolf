using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface IOrder
    {
        public Order GetById(int id);
        public IEnumerable<Order> GetAll();
        public void Add (Order order);
        public void Edit (Order order);
        public void Delete(int id);
    }
}
