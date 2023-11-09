using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class BlogCategory:BaseModel
    {
        [Required]
        public string Title { get; set; }
    }
}
