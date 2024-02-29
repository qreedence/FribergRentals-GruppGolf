using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface IUser<T> where T : User
    {
        public T GetById(int id);
        public List<User> GetAll();
        //public void Add (User user);  // This is not common for admin and customer and cant be inherited.
        public void Edit (T user);
        public void Delete (int id);
    }
}
