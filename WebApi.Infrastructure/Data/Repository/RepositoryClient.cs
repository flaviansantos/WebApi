using WebApi.Domain.Core.Interface.Repositories;
using WebApi.Domain.Entities;

namespace WebApi.Infrastructure.Data.Repository
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext sqlContext;

        public RepositoryClient(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
