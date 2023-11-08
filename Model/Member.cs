using API.Model.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Member:BaseModel
    {
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
        [Required]
        public Role UserRole { get; set; }
    }
}
