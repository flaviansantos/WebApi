using WebApi.Domain.Core.Interface.Repositories;
using WebApi.Domain.Entities;

namespace WebApi.Infrastructure.Data.Repository
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduct(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
