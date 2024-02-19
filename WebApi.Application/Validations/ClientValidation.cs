using FluentValidation;
using WebApi.Application.Dtos;

namespace WebApi.Application.Validations
{
    public class ClientValidation : AbstractValidator<ClientDto>
    {
        public ClientValidation()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty().WithMessage("Invalid Name");
            RuleFor(c => c.Email).NotNull().NotEmpty().WithMessage("Invalid Email");
        }
    }
}
