using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }
    }
}
