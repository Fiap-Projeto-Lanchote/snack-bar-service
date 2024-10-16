using FluentValidation;

namespace Application.Product.Commands.Product.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty();

            RuleFor(x => x.CategoryId)
                .NotEmpty();

            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(3, 100);
        }
    }
}
