using WebApi.Domain.Core.Interface.Repositories;
using WebApi.Domain.Core.Interface.Services;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct)
            : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}
