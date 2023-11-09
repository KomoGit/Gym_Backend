using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace API.Model
{
    public class Blog:BaseModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        //Keeping bodytexts as list in hopes of being able to
        //give different designs for each blog post if possible.
        public List<string> BodyTexts { get; set; }
        [Required]
        public Member Author { get; set; }
        [Required]
        public List<BlogCategory> Categories { get; set; }
    }
}
