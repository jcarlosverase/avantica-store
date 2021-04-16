using Catalog.Application.Products.Queries;
using AutoMapper;
using Catalog.Domain.Entities;

namespace Catalog.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            //Source -> Destination
            CreateMap<Product, ProductDto>();
        }
    }
}
