using System.Threading.Tasks;

namespace Catalog.Application.Products.Queries
{
    public interface IProductQuery
    {
        Task<ProductDto> GetAsync(int id);
    }
}
