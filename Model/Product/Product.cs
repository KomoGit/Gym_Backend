using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model.Product
{
    public class Product:BaseModel
    {
        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; }
        [Required]
        [MaxLength(500)]
        public string ProductDescription { get; set; }
        [Required]
        public string ProductPrice { get; set; }
        [NotMapped]
        public List<ProductImage> ImageLinks { get; set; }
    }
}
