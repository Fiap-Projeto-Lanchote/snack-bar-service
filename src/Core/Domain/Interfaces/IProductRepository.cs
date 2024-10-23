using Domain.Entities;

namespace Infra.DataBase.Repositories
{
    public interface IProductRepository
    {
        Task Create(Produto request, CancellationToken cancellationToken);

        Task Delete(Produto request, CancellationToken cancellationToken);

        Task Update(Produto request, CancellationToken cancellationToken);

        Task<Produto?> Exists(string Nome, CancellationToken cancellationToken);

    }
}
