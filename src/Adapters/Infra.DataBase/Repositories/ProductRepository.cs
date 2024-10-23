using Domain.Entities;
using Infra.DataBase.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.DataBase.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Produto request, CancellationToken cancellationToken)
        {
            await _context.Produto.AddAsync(request, cancellationToken);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Produto request, CancellationToken cancellationToken)
        {
            _context.Produto.Remove(request);
            await _context.SaveChangesAsync();
        }

        public async Task<Produto?> Exists(string Nome, CancellationToken cancellationToken)
        {
            return await _context.Produto.SingleOrDefaultAsync(x => x.Nome == Nome, cancellationToken);
        }

        public async Task Update(Produto request, CancellationToken cancellationToken)
        {
            _context.Produto.Update(request);
            await _context.SaveChangesAsync();
        }
    }
}
