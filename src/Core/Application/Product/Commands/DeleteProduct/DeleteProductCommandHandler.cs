using Application.Product.Commands.CreateProduct;
using CrossCutting;
using Domain.Entities;
using Infra.DataBase.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Product.Commands.DeleteProduct
{
    public sealed class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<DeleteProductCommandHandler> _logger;

        public DeleteProductCommandHandler(IProductRepository productRepository,
                                         ILogger<DeleteProductCommandHandler> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<Result> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Deletar produto");

                var produto = await _productRepository.Exists(request.Id, cancellationToken);

                if (produto is null)
                    return Result.Failure("Produto", "Produto não existe");

                await _productRepository.Delete(produto, cancellationToken);

                _logger.LogInformation("Produto deletado");

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure("Produto", "Erro ao deletar produto");
            }
        }
    }
}
