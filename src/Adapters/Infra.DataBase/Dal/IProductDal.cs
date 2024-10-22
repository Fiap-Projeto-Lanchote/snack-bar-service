using Application.Product.Query.GetById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataBase.Dal
{
    public interface IProductDal
    {
        Task<IEnumerable<GetProductByIdViewModel>> GetProductById(Guid Id, CancellationToken cancellationToken);
        Task<IEnumerable<GetProductByIdViewModel>> GetProductByCategory(Guid PkCategoria, CancellationToken cancellationToken)
    }
}
