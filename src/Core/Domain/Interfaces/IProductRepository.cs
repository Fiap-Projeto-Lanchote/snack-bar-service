using Domain.Entities;

namespace Infra.DataBase.Repositories
{
    public interface IProductRepository
    {
        Task Create(Product request, CancellationToken cancellationToken);

        Task Delete(Product request, CancellationToken cancellationToken);

        Task Update(Product request, CancellationToken cancellationToken);

        Task<Product?> Exists(Product Product, CancellationToken cancellationToken);

    }
}
