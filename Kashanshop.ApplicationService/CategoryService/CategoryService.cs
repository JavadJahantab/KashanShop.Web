using Kashanshop.Data.sqlserver;
using Kashanshop.Domain;
using Microsoft.EntityFrameworkCore;

namespace Kashanshop.ApplicationService.CategoryService;

public class CategoryService:ICategoryService
{
    private ApplicationDbContext _context;

    public CategoryService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task NewCategoryAsync(CategoryViewModel model)
    {
        ProductCategory category = new ProductCategory()
        {
            Code = model.Code,
            Name = model.Name,
            LeaderCategoryId = model.LeaderCategoryId,
        };
        await _context.Categories.AddAsync(category);
    }

    public async Task<List<CategoryViewModel>> GetCategorySubListAsync(int categoryRootId)
    {
        List<ProductCategory> categories=await _context.Categories
            .Where(x => x.LeaderCategoryId == categoryRootId).ToListAsync();
        List<CategoryViewModel> list = new List<CategoryViewModel>();
        foreach (var c in categories)
        {
            list.Add(new CategoryViewModel()
            {
                Code = c.Code,
                Name = c.Name,
                LeaderCategoryId = c.LeaderCategoryId
            });
        }

        return list;
    }

    public async Task<List<CategoryViewModel>> GetCategoryRootListAsync(int categorySubId)
    {
        List<ProductCategory> categories = await _context.Categories.ToListAsync();
        List<CategoryViewModel> list = new List<CategoryViewModel>();
        foreach (var c in categories)
        {
            list.Add(new CategoryViewModel()
            {
                Code = c.Code,
                Name = c.Name,
                LeaderCategoryId = c.LeaderCategoryId
            });
        }

        return list;
    }

    public async Task<List<CategoryViewModel>> GetAllCategoryListAsync()
    {
        List<ProductCategory> categories=await _context.Categories
            .ToListAsync();
        List<CategoryViewModel> list = new List<CategoryViewModel>();
        foreach (var c in categories)
        {
            list.Add(new CategoryViewModel()
            {
                Code = c.Code,
                Name = c.Name,
                LeaderCategoryId = c.LeaderCategoryId
            });
        }

        return list;
    }

    public async Task DeleteCategoryAsync(int categoryId)
    {
        var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == categoryId);
        _context.Categories.Remove(category);
    }

    public async Task EditCategoryAsync(CategoryViewModel model)
    {
        var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == model.Id);
        _context.Categories.Remove(category);
    }
}