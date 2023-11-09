using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    /// <summary>
    /// Data shared across all models of the app
    /// </summary>
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime UpdateDate { get; set; }
    }
}
