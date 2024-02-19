using FluentValidation;
using WebApi.Application.Dtos;

namespace WebApi.Application.Validations
{
    public class ProductValidation : AbstractValidator<ProductDto>
    {
        public ProductValidation()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty().WithMessage("Invalid Name.");
            RuleFor(c => c.ProductValue).NotNull().NotEmpty().WithMessage("Invalid Product Value.");
        }
    }
}
