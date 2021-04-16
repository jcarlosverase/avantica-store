using Application.Products.Queries;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
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
