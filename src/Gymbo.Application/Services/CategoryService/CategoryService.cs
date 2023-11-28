using Gymbo.Application.DTOs.CategoryDTOs;

namespace Gymbo.Application.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public Task<List<GetCategoriesDTO>> GetAllCategories(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<GetCategoryDTO> GetCategory(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<GetCategoryDTO> CreateCategory(CreateCategoryDTO request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<GetCategoryDTO> UpdateCategory(UpdateCategoryDTO request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(UpdateCategoryDTO request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
