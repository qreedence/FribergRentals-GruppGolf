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

        public async Task AddAsync(Car car)
        {
            await _applicationDbContext.Cars.AddAsync(car);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var car = await _applicationDbContext.Cars.FindAsync(id);
            if (car != null)
            {
                _applicationDbContext.Cars.Remove(car);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task EditAsync(Car car)
        {
           if (car != null)
            {
                _applicationDbContext.Cars.Update(car);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Car>> GetAllAsync()
        {
          return await _applicationDbContext.Cars.ToListAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _applicationDbContext.Cars.FindAsync(id);
        }
    }
}
