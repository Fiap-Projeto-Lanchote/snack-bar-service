using Application.Product.Commands.CreateProduct;
using CrossCutting;
using Domain.Entities;
using Infra.DataBase.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Product.Commands.UpdateProduct
{
    public sealed class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<UpdateProductCommandHandler> _logger;

        public UpdateProductCommandHandler(IProductRepository productRepository,
                                         ILogger<UpdateProductCommandHandler> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<Result> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Atualizar produto");

                var produto = await _productRepository.Exists(request.Id, cancellationToken);

                if (produto is null)
                    return Result.Failure("Produto", "Produto não existe");

                var product = new Produto()
                {
                    Id = request.Id,
                    FkCategoria = request.FkCategoria,
                    Nome = request.Name
                };

                await _productRepository.Update(product, cancellationToken);

                _logger.LogInformation("Produto atualizado");

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure("Produto", "Erro ao atualizar produto");
            }
        }
    }
}
