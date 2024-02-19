using WebApi.Application.Dtos;

namespace WebApi.Application.Interface
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductDto productDto);

        void Update(ProductDto productDto);

        void Remove(ProductDto productDto);

        IEnumerable<ProductDto> GetAll();

        ProductDto GetById(int id);
    }
}
