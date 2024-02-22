using AutoMapper;
using WebApi.Application.Dtos;
using WebApi.Domain.Entities;

namespace WebApi.Application.Mappers
{
    public class DtoToModelMappingProduct : Profile
    {
        public DtoToModelMappingProduct()
        {
            ProductMap();
        }

        private void ProductMap()
        {
            CreateMap<ProductDto, Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.ProductValue, opt => opt.MapFrom(x => x.ProductValue))
                .ForMember(dest => dest.IsAvailable, opt => opt.Ignore());
        }
    }
}
