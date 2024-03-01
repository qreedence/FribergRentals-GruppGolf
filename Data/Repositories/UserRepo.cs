using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRentals.Data.Repositories
{
    public abstract class UserRepo<T> : IUser<T> where T : User
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
        public async Task<T> DeleteAsync(int id)
        {
            var user = await _applicationDbContext.Users.FindAsync(id);
            if (user != null)
            {
                _applicationDbContext.Users.Remove(user);
                await _applicationDbContext.SaveChangesAsync();
            }
            return null;
        }

        public async Task<T> EditAsync(T user)
        {
            if (user != null)
            {
                _applicationDbContext.Users.Update(user);
                await _applicationDbContext.SaveChangesAsync();

            }
            return null;
        }



        public async Task<List<User>> GetAllAsync()
        {
           return await _applicationDbContext.Users.ToListAsync();          
        }

        public async Task<T> GetByIdAsync(int id)
        {
            await _applicationDbContext.Users.FindAsync(id);
            return null;
        }


    }
}
