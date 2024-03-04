using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
    public interface IUser<T> where T : User
    {
        public Task AddAsync(T user);
        public Task<User> GetByIdAsync(int id);
        public Task<List<User>> GetAllAsync();
        //public void Add (User user);  // This is not common for admin and customer and cant be inherited.
        public Task EditAsync (T user);
        public Task DeleteAsync (int id);

        public Task<User> ValidateUser(string email, string password);
        public Task UpdateSessionToken(User user, string token);
        public Task<User> ValidateSessionToken(string token);
    }
}
