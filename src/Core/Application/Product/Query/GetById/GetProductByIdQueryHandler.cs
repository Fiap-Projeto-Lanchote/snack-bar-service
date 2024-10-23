using Application.Product.Commands.CreateProduct;
using CrossCutting;
using Infra.DataBase.Dal;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Product.Query.GetById
{
    public sealed class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Result<GetProductByIdViewModel>>
    {
        private readonly IProductDal _productDal;
        private readonly ILogger<GetProductByIdQueryHandler> _logger;

        public GetProductByIdQueryHandler(IProductDal productDal,
                                         ILogger<GetProductByIdQueryHandler> logger)
        {
            _productDal = productDal;
            _logger = logger;
        }

        public async Task<Result<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Encontrar produto");

                var produto = await _productDal.GetProductById(request.Id, cancellationToken);

                if (produto is null)
                    return Result<GetProductByIdViewModel>.Failure("Produto", "Produto não existe");

                _logger.LogInformation("Produto encontrado");

                var produtoVM = new GetProductByIdViewModel(produto);

                return Result<GetProductByIdViewModel>.Success(produtoVM);
            }
            catch (Exception ex)
            {
                return Result<GetProductByIdViewModel>.Failure("Produto", "Erro ao buscar produto");
            }
        }
    }
}

