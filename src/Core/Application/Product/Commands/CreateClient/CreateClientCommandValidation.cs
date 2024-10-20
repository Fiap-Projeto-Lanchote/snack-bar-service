using Application.Product.Commands.CreateProduct;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.Commands.CreateClient
{
    public class CreateClientCommandValidation : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidation()
        {
            RuleFor(x => x.Id)
                .NotEmpty();

            RuleFor(x => x.Nome)
                .NotEmpty()
                .Length(3, 100);
            RuleFor(x => x.CPF)
                .NotEmpty()
                .GreaterThan(10000000000)
                .LessThan(99999999999);
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();
        }
    }
}
