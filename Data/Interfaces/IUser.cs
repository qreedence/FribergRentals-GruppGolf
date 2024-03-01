using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface IUser<T> where T : User
    {
        public Task<T> GetByIdAsync(int id);
        public Task<List<T>> GetAllAsync();
        //public void Add (User user);  // This is not common for admin and customer and cant be inherited.
        public Task<T> EditAsync (T user);
        public Task<T> DeleteAsync (int id);
    }
}
