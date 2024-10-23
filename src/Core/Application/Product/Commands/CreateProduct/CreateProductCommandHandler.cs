using CrossCutting;
using Infra.DataBase.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using Domain.Entities;

namespace Application.Product.Commands.CreateProduct
{
    public sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<CreateProductCommandHandler> _logger;

        public CreateProductCommandHandler(IProductRepository productRepository,
                                         ILogger<CreateProductCommandHandler> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<Result> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Novo produto {0}", request.Name);

                var exists = await _productRepository.Exists(request.Id, cancellationToken);

                if (exists is not null)
                    return Result.Failure("Produto", "Produto já existe");

                var product = new Produto()
                {
                    Id = request.Id,
                    FkCategoria = request.FkCategoria,
                    Nome = request.Name
                };

                await _productRepository.Create(product, cancellationToken);

                _logger.LogInformation("Criado novo produto");

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure("Produto", "Erro ao criar produto");
            }
        }
    }
}
