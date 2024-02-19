using AutoMapper;
using WebApi.Application.Dtos;
using WebApi.Domain.Entities;

namespace WebApi.Application.Mappers
{
    public class DtoToModelMappingClient : Profile
    {
        public DtoToModelMappingClient()
        {
            ClientMap();
        }

        private void ClientMap()
        {
            CreateMap<ClientDto, Client>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.DateRegister, opt => opt.Ignore())
                .ForMember(dest => dest.IsActive, opt => opt.Ignore());

        }
    }
}
