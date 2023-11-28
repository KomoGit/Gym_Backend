using System.ComponentModel.DataAnnotations;

namespace Gymbo.Application.DTOs.CategoryDTOs
{
    public class UpdateCategoryDTO
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
