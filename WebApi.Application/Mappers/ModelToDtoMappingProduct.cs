using AutoMapper;
using WebApi.Application.Dtos;
using WebApi.Domain.Entities;

namespace WebApi.Application.Mappers
{
    public class ModelToDtoMappingProduct : Profile
    {
        public ModelToDtoMappingProduct()
        {
            ProdutoDtoMap();
        }
        private void ProdutoDtoMap()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.ProductValue, opt => opt.MapFrom(x => x.ProductValue));
        }
    }
}
