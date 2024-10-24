using Domain.Entities;
using Infra.DataBase.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataBase.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Order request, CancellationToken cancellationToken)
        {
            await _context.Order.AddAsync(request, cancellationToken);
            await _context.SaveChangesAsync();
        }
    }
}
