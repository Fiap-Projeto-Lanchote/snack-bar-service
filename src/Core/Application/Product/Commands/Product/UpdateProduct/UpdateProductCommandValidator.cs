using FluentValidation;

namespace Application.Product.Commands.Product.UpdateProduct
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
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
