using CrossCutting;
using MediatR;

namespace Application.Product.Commands.DeleteProduct
{
    public record DeleteProductCommand(Guid Id) : IRequest<Result>;
}
