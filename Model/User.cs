using API.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    /// <summary>
    /// Represents all registered users of the applications.
    /// This includes Admins, Moderators, and regular members.
    /// </summary>
    public class User:BaseModel
    {
        [Required(ErrorMessage = "Cannot be empty")]
        public string Fullname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [PasswordPropertyText(true)]
        public string Password { get; set; }
        [Required]
        public Role UserRole { get; set; }
        [Required]
        public string Token { get; set; }
    }
}
