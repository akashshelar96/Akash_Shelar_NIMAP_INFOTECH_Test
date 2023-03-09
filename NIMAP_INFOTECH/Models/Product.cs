using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NIMAP_INFOTECH.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        [ForeignKey]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
