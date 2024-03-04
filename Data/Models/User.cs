using System.ComponentModel;
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
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The passwords do not match")]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }
        public string? SessionToken { get; set; }
    }
}
