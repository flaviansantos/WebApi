using WebApi.Domain.Core.Interface.Repositories;
using WebApi.Domain.Core.Interface.Services;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient)
            : base(repositoryClient)
        {
            this.repositoryClient = repositoryClient;
        }
    }
}
