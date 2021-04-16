using AutoMapper;
using AutoMapper.QueryableExtensions;
using Catalog.Infrastructure.Persistence;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Application.Products.Queries
{
    public class ProductQuery : IProductQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductQuery(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductDto> GetAsync(int id)
        {
            var product = _context.Products
                                .Where(x => x.ProductId == id)
                                .ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
                                .Single();

            return product;
        }
    }
}
