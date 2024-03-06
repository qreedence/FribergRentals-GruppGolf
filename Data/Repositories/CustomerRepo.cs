using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRentals.Data.Repositories
{
    public class CustomerRepo : UserRepo<Customer>, ICustomer
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CustomerRepo(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task AddOrderAsync(Customer customer, Order order)
        {
            customer.CustomerOrders.Add(order);
            await _applicationDbContext.SaveChangesAsync(); 
        }

        //public void Add(Customer customer)
        //{
        //    _applicationDbContext.Add(customer);
        //    SaveUserChanges(customer);
        //}

        //public void AddOrder(Order order, Customer customer)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Edit(User user)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<List<Customer>> GetAllAsync()
        //{             
        //    return await _applicationDbContext.Customers.ToListAsync();
        //}

        //public User GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}
        //public void SaveUserChanges(User user)
        //{
        //    _applicationDbContext.Add(user);
        //    _applicationDbContext.SaveChanges();
        //}
    }
}
