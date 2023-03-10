using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NIMAP_INFOTECH.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }

        [ForeignKey("Products")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
