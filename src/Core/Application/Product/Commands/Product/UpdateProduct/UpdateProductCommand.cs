using CrossCutting;
using MediatR;

namespace Application.Product.Commands.Product.UpdateProduct
{
    public record UpdateProductCommand : IRequest<Result>
    {
        public required Guid Id { get; set; }
        public required string? Name { get; set; }
        public required Guid CategoryId { get; set; }
    }
}
