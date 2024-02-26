using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface IUser
    {
        public User GetById(int id);
        public IEnumerable<User> GetAll();
        public void Add (User user);
        public void Edit (User user);
        public void Delete (int id);
    }
}
