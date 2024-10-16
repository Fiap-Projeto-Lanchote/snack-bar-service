using CrossCutting;
using MediatR;

namespace Application.Product.Commands.Product.CreateProduct
{
    public sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Result>
    {
        public CreateProductCommandHandler()
        {

        }

        public async Task<Result> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return Result.Success();
        }
    }
}
