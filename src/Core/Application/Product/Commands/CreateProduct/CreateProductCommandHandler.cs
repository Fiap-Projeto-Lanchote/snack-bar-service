using CrossCutting;
using MediatR;

namespace Application.Product.Commands.CreateProduct
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
