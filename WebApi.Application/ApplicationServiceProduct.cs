using AutoMapper;
using WebApi.Application.Dtos;
using WebApi.Application.Interface;
using WebApi.Domain.Core.Interface.Services;
using WebApi.Domain.Entities;

namespace WebApi.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapper mapper;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapper mapper)
        {
            this.serviceProduct = serviceProduct;
            this.mapper = mapper;
        }

        public void Add(ProductDto productDto)
        {
            var produto = mapper.Map<Product>(productDto);
            serviceProduct.Add(produto);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var produtos = serviceProduct.GetAll();
            var produtosDto = mapper.Map<IEnumerable<ProductDto>>(produtos);
            return produtosDto;
        }

        public ProductDto GetById(int id)
        {
            var produto = serviceProduct.GetById(id);
            var produtoDto = mapper.Map<ProductDto>(produto);
            return produtoDto;
        }

        public void Remove(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            serviceProduct.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var produto = mapper.Map<Product>(productDto);
            serviceProduct.Update(produto);
        }
    }
}
