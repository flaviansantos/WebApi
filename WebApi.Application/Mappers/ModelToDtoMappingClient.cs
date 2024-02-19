using AutoMapper;
using WebApi.Application.Dtos;
using WebApi.Domain.Entities;

namespace WebApi.Application.Mappers
{
    public class ModelToDtoMappingClient : Profile
    {

        public ModelToDtoMappingClient()
        {
            ClientDtoMap();
        }

        private void ClientDtoMap()
        {
            CreateMap<Client, ClientDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email));
        }
    }
}
