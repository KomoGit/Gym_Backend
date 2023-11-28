using System.ComponentModel.DataAnnotations;

namespace Gymbo.Application.DTOs.CategoryDTOs
{
    public class CreateCategoryDTO
    {
        [Required]
        public string Title { get; set; }
    }
}
