using System.ComponentModel.DataAnnotations;
using API.Model.Blog;

namespace API.Model
{
    /// <summary>
    /// Category for both Blog posts and Shop items.
    /// </summary>
    public class Category:BaseModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        //Both items and blogs use the same category model as they are same.
        //To ensure category of blog doesn't show up in item category,
        //We toggle this boolean.
        public bool BlogOnlyCategory { get; set; }
        [Required]
        public ICollection<BlogCategory> BlogCategories { get; set; }
    }
}
