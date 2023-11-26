using System.ComponentModel.DataAnnotations;

namespace API.Model.Product
{
    public class ProductImage:BaseModel
    {
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public Product Product { get; set; }
    }
}
