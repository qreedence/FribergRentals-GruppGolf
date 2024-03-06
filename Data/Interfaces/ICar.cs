using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface ICar
    {
        Task<Car> GetByIdAsync(int id);
        public Task<List<Car>> GetAllAsync();
        public Task AddAsync(Car car);
        public Task EditAsync(Car car);
        public Task DeleteAsync(int id);
    }
}
