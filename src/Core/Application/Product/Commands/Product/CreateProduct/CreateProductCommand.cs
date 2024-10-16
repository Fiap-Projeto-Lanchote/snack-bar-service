using CrossCutting;
using MediatR;

namespace Application.Product.Commands.Product.CreateProduct
{
    public record CreateProductCommand : IRequest<Result>
    {
        public required Guid Id { get; set; }
        public required string? Name { get; set; }
        public required Guid CategoryId { get; set; }
    }
}
