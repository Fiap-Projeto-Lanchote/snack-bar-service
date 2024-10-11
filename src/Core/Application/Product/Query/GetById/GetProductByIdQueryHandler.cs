using CrossCutting;
using MediatR;

namespace Application.Product.Query.GetById
{
    public sealed class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Result<GetProductByIdViewModel>>
    {
        public async Task<Result<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return Result<GetProductByIdViewModel>.Success(new GetProductByIdViewModel(request.Id));
        }
    }
}
