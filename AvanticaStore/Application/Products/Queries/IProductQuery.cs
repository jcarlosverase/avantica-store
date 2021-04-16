using System.Threading.Tasks;

namespace Application.Products.Queries
{
    public interface IProductQuery
    {
        Task<ProductDto> GetAsync(int id);
    }
}
