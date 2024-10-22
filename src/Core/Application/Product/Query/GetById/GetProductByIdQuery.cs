using CrossCutting;
using Domain.ViewModel.Product;
using MediatR;

namespace Application.Product.Query.GetById
{
    public record GetProductByIdQuery : IRequest<Result<GetProductByIdViewModel>>
    {
        public GetProductByIdQuery(Guid id) => Id = id;

        public Guid Id { get; }
    }
}
