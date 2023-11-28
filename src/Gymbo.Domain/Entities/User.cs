using System.ComponentModel.DataAnnotations;

namespace Gymbo.Domain.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string Fullname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public Token UserTokens { get; set; }
    }
}
