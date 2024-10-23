using Domain.Entities;

namespace Infra.DataBase.Dal
{
    public interface IProductDal
    {
        Task<Produto?> GetProductById(Guid Id, CancellationToken cancellationToken);
        Task<IEnumerable<Produto>> GetProductByCategory(int PkCategoria, CancellationToken cancellationToken);
    }
}
