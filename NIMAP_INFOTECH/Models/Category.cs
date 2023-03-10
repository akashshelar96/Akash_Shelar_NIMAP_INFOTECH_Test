using System.ComponentModel.DataAnnotations;

namespace NIMAP_INFOTECH.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
