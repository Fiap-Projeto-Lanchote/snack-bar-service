using Application.Product.Query.GetById;
using Domain.Entities;
using Infra.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataBase.Dal
{
    public class ProductDal : IProductDal
    {
        private readonly ApplicationDbContext _context;

        public ProductDal(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> GetProductByCategory(Guid PkCategoria, CancellationToken cancellationToken)
        {
            return await _context.Produto.Where(x => x.FkCategoria == PkCategoria).OrderBy(z => z.Nome).ToArrayAsync(cancellationToken);
        }

        public async Task<IEnumerable<Produto>> GetProductById(Guid Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
