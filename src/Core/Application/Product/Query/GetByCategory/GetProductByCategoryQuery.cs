using CrossCutting;
using MediatR;

namespace Application.Product.Query.GetByCategory
{
    public record GetProductByCategoryQuery : IRequest<Result<GetProductByCategoryViewModel>>
    {
        public GetProductByCategoryQuery(int id) => Id = id;

        public int Id { get; }
    }
}
