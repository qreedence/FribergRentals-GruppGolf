using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;

namespace FribergRentals.Data.Repositories
{
    public class OrderRepo : IOrder
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ICar _carRepo;
        private readonly ICustomer _customerRepo;
        private readonly IAdmin _adminRepo;

        public OrderRepo(ApplicationDbContext applicationDbContext, ICar carRepo, ICustomer customerRepo, IAdmin adminRepo)
        {
            _applicationDbContext = applicationDbContext;
            _carRepo = carRepo;
            _customerRepo = customerRepo;
            _adminRepo = adminRepo;
        }

        public void Add(Order order)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Order order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
