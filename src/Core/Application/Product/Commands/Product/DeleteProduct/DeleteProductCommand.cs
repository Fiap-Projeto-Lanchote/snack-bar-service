using CrossCutting;
using MediatR;

namespace Application.Product.Commands.Product.DeleteProduct
{
    public record DeleteProductCommand(Guid Id) : IRequest<Result>;
}
