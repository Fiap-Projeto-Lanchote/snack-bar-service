using Application.Product.Query.GetById;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataBase.Dal
{
    public interface IProductDal
    {
        Task<IEnumerable<Produto>> GetProductById(Guid Id, CancellationToken cancellationToken);
        Task<IEnumerable<Produto>> GetProductByCategory(Guid PkCategoria, CancellationToken cancellationToken);
    }
}
