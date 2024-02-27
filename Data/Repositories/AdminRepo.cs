using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRentals.Data.Repositories
{
    public class AdminRepo : IAdmin
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AdminRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Add(Admin admin)
        {
            _applicationDbContext.Add(admin);
            SaveUserChanges(admin);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void Edit(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void SaveUserChanges(Admin admin)
        {
            _applicationDbContext.Attach(admin).State = EntityState.Modified;
            _applicationDbContext.SaveChanges();
        }

        IEnumerable<User> IUser.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
