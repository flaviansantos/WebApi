using AutoMapper;
using WebApi.Application.Dtos;
using WebApi.Application.Interface;
using WebApi.Domain.Core.Interface.Services;
using WebApi.Domain.Entities;

namespace WebApi.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapper mapper;
        public ApplicationServiceClient(IServiceClient serviceClient, IMapper mapper)
        {
            this.serviceClient = serviceClient;
            this.mapper = mapper;
        }
        public void Add(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Add(client);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clientes = serviceClient.GetAll();
            var clientesDto = mapper.Map<IEnumerable<ClientDto>>(clientes);

            return clientesDto;
        }

        public ClientDto GetById(int id)
        {
            var cliente = serviceClient.GetById(id);
            var clienteDto = mapper.Map<ClientDto>(cliente);
            return clienteDto;
        }

        public void Remove(ClientDto clientDto)
        {
            var cliente = mapper.Map<Client>(clientDto);
            serviceClient.Remove(cliente);
        }

        public void Update(ClientDto clientDto)
        {
            var cliente = mapper.Map<Client>(clientDto);
            serviceClient.Update(cliente);
        }
    }
}
