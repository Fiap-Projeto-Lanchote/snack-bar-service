using Application.Product.Commands.CreateProduct;
using CrossCutting;
using Infra.DataBase.Dal;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Application.Product.Query.GetByCategory
{
    public sealed class GetProductByCategoryQueryHandler : IRequestHandler<GetProductByCategoryQuery, Result<GetProductByCategoryViewModel>>
    {
        private readonly IProductDal _productDal;
        private readonly ILogger<GetProductByCategoryQueryHandler> _logger;

        public GetProductByCategoryQueryHandler(IProductDal productDal,
                                         ILogger<GetProductByCategoryQueryHandler> logger)
        {
            _productDal = productDal;
            _logger = logger;
        }

        public async Task<Result<GetProductByCategoryViewModel>> Handle(GetProductByCategoryQuery request, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Encontrar produtos pela categoria");

                var produtos = await _productDal.GetProductByCategory(request.Id, cancellationToken);

                if (!produtos.Any())
                    return Result<GetProductByCategoryViewModel>.Failure("Produto", "Não existem produtos para essa categoria");

                _logger.LogInformation("Produto encontrado");

                var produtoVM = new GetProductByCategoryViewModel(produtos);

                return Result<GetProductByCategoryViewModel>.Success(produtoVM);
            }
            catch (Exception ex)
            {
                return Result<GetProductByCategoryViewModel>.Failure("Produto", "Erro ao buscar produtos");
            }
        }
    }
}

