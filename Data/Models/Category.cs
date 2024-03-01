namespace FribergRentals.Data.Models
{
    public class Category : BaseDomainEntity
    {
        public Category() { }
        public string Name { get; set; }
        public List<Car>? Cars { get; set; }
    }
}
