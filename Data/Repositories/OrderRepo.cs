using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRentals.Data.Repositories
{
    public class OrderRepo : IOrder
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ICar _carRepo;
        private readonly IUser<User> _userRepo;

        public OrderRepo(ApplicationDbContext applicationDbContext, ICar carRepo, IUser<User> userRepo)
        {
            _applicationDbContext = applicationDbContext;
            _carRepo = carRepo;
            _userRepo = userRepo;
        }

        public async Task AddAsync(Order order)
        {
            order.Car = await _carRepo.GetByIdAsync(order.Car.Id);
            order.User = await _userRepo.GetByIdAsync(order.User.Id);
            _applicationDbContext.Orders.Add(order);
            _applicationDbContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            Order order = await GetByIdAsync(id);
            _applicationDbContext.Orders.Remove(order);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Order order)
        {
            _applicationDbContext.Orders.Update(order);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _applicationDbContext.Orders
               .OrderBy(x => x.Id)
               .Include(order => order.Car)
               .Include(order => order.User)
               .ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _applicationDbContext.Orders
                .Include(x => x.Car)
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
