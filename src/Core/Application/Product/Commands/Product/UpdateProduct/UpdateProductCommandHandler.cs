using CrossCutting;
using MediatR;

namespace Application.Product.Commands.Product.UpdateProduct
{
    public sealed class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Result>
    {
        public UpdateProductCommandHandler()
        {

        }

        public async Task<Result> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return Result.Success();
        }
    }
}
