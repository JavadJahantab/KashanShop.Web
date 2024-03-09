

using Kashanshop.Web.Models.Product;

namespace Kashanshop.ApplicationService.ProductService;

public interface IProductInventoryService
{
    Task NewProductInventoryAsync(ProductInventoryViewModel productInventory);
    Task<List<ProductInventoryViewModel>> GetProductInventoryListAsync(ProductInventoryViewModel productInventory);
    Task<ProductInventoryViewModel> GetProductInventoryAsync(ProductInventoryViewModel productInventory);
}