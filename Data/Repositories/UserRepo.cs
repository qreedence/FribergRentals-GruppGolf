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

        public void Add(T user)
        {
            throw new NotImplementedException();
        }       
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(T user)
        {
            throw new NotImplementedException();
        }



        public List<User> GetAll()
        {
            //return await _applicationDbContext.Customers.ToListAsync();
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }


    }
}
