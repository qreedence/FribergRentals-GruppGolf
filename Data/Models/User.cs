using System.ComponentModel.DataAnnotations;

namespace FribergRentals.Data.Models
{
    public abstract class User : BaseDomainEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
