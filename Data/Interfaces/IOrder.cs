using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface IOrder
    {
        public Task<Order> GetByIdAsync(int id);
        public Task<List<Order>> GetAllAsync();
        public Task AddAsync (Order order);
        public Task EditAsync (Order order);
        public Task DeleteAsync(int id);
    }
}
