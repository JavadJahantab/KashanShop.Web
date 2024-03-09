

namespace Kashanshop.ApplicationService.ProductService;

public interface IProductService
{
    Task NewProductAsync(IProductViewService product);
    Task<List<IProductViewService>> GetProductAsync(string name);
    Task<List<IProductViewService>> GetProductAsync(int code);
    Task<List<IProductViewService>> GetProductListAsync();
}