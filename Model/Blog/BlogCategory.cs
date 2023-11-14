using System.ComponentModel.DataAnnotations;

namespace API.Model.Blog
{
    /// <summary>
    /// Many to many relationship between two models.
    /// </summary>
    public class BlogCategory : BaseModel
    {
        [Required]
        public Blog Blog { get; set; }
        [Required]
        public Category Category { get; set; }
    }
}
