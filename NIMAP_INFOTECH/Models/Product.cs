using System.ComponentModel.DataAnnotations;

namespace NIMAP_INFOTECH.Models
{
    public class Product
    {
        [Key] 
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Product name Can't br blank")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Category Id Can't br blank")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category name Can't br blank")]
        public string CategoryName { get; set; }

    }
}
