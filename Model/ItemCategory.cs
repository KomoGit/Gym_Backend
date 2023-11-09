using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    /// <summary>
    /// Category for items sold in the shop
    /// </summary>
    public class ItemCategory:BaseModel
    {
        [Required]
        public string Title { get; set; }
    }
}
