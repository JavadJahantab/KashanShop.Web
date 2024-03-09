using Kashanshop.Domain;

namespace Kashanshop.ApplicationService;

public interface ICategoryService
{
    Task NewCategoryAsync(CategoryViewModel model);
    Task<List<CategoryViewModel>> GetCategorySubListAsync(int categoryRootId);
    Task<List<CategoryViewModel>> GetCategoryRootListAsync(int categorySubId);
    Task<List<CategoryViewModel>> GetAllCategoryListAsync();
    Task DeleteCategoryAsync(int categoryId);
    Task EditCategoryAsync(CategoryViewModel model);
}