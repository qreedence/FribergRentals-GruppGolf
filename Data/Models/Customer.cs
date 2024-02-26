namespace FribergRentals.Data.Models
{
    public class Customer : User
    {
        public virtual List<Order> CustomerOrders { get; set; }
    }
}
