using CrossCutting;
using MediatR;

namespace Application.Product.Commands.CreateProduct
{
    public record CreateProductCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
