using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;

namespace FribergRentals.Data.Repositories
{
    public class UserRepo : IUser
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Add(Customer customer)
        {
            throw new NotImplementedException();

        }
        public void Add(Admin admin)
        {
            throw new NotImplementedException();

        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
