using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FribergRentals.Data.Models
{
    public class Car : BaseDomainEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<Category> Category { get; set; }
    }
}
