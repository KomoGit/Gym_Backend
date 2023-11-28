using System.ComponentModel.DataAnnotations;

namespace Gymbo.Domain.Entities
{
    public class Blog : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string BodyTexts { get; set; }
        //[Required]
        //public ICollection<BlogCategory> Categories { get; set; }
        //[Required]
        public User Author { get; set; }
        #region Images
        [Required]
        public string BlogImageLink { get; set; }
        [Required]
        public string BlogPreviewImageLink { get; set; }
        #endregion
    }
}
