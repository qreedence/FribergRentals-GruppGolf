using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRentals.Data.Repositories
{
    public class CarRepo : ICar
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CarRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Task AddAsync(Car car)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(Car car)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Car>> GetAllAsync()
        {
          return await _applicationDbContext.Cars.ToListAsync();
        }

        public Task<Car> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
