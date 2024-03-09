

using Kashanshop.Web.Models.Product;

namespace Kashanshop.ApplicationService.ProductService;

public interface IProductPriceService
{
    Task NewProductPriceAsync(ProductPriceViewModel productPrice);
    Task<List<ProductPriceViewModel>> GetProductsPriceListAsync(ProductPriceViewModel productPrice);
    Task<ProductPriceViewModel> GetLastProductsPriceAsync(ProductPriceViewModel productPrice);
}