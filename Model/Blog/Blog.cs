using System.ComponentModel.DataAnnotations;

namespace API.Model.Blog
{
    public class Blog : BaseModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string BodyTexts { get; set; }
        [Required]
        public ICollection<BlogCategory> Categories { get; set; }
        [Required]
        public User Author { get; set; }

        #region Images
        [Required]
        public string BlogImageLink { get; set; }
        [Required]
        public string BlogPreviewImageLink { get; set; }
        #endregion
    }
}
