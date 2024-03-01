using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRentals.Data.Repositories
{
    public class UserRepo<T> : IUser<T> where T : User
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task AddAsync(T user)
        {
            if (user != null)
            {
                _applicationDbContext.Users.Add(user);
                await _applicationDbContext.SaveChangesAsync();
            }         
        }
        public async Task DeleteAsync(int id)
        {
            var user = await _applicationDbContext.Users.FindAsync(id);
            if (user != null)
            {
                _applicationDbContext.Users.Remove(user);
                await _applicationDbContext.SaveChangesAsync();
            }
            
        }

        public async Task EditAsync(T user)
        {
            if (user != null)
            {
                _applicationDbContext.Users.Update(user);
                await _applicationDbContext.SaveChangesAsync();

            }
        }



        public async Task<List<User>> GetAllAsync()
        {
           return await _applicationDbContext.Users.ToListAsync();          
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _applicationDbContext.Users.FindAsync(id);
            
        }


    }
}
