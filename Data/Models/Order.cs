using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FribergRentals.Data.Models
{
    public class Order : BaseDomainEntity
    {
        public Car Car { get; set; }
        public User User { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime TimeOfOrder { get; set;  }
        
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public decimal TotalPrice { get; set; }
    }
}
