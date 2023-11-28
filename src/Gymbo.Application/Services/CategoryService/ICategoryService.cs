using Gymbo.Application.DTOs.CategoryDTOs;

namespace Gymbo.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        public Task<List<GetCategoriesDTO>> GetAllCategories(CancellationToken cancellationToken);
        public Task<GetCategoryDTO> GetCategory(Guid id,CancellationToken cancellationToken);
        public Task<GetCategoryDTO> CreateCategory(CreateCategoryDTO request,CancellationToken cancellationToken);
        public Task<GetCategoryDTO> UpdateCategory(UpdateCategoryDTO request);
        public Task DeleteCategory(UpdateCategoryDTO request,CancellationToken cancellationToken);
    }
}
