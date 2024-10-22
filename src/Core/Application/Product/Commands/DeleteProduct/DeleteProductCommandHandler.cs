using CrossCutting;
using MediatR;

namespace Application.Product.Commands.DeleteProduct
{
    public sealed class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Result>
    {
        public DeleteProductCommandHandler()
        {

        }

        public async Task<Result> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return Result.Success();
        }
    }
}
