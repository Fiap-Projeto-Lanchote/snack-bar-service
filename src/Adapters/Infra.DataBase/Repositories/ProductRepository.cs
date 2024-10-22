using Azure.Core;
using Domain.Entities;
using Domain.ViewModel.Product;
using Infra.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataBase.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Product request, CancellationToken cancellationToken) => await _context.Product.AddAsync(request, cancellationToken);        

        public async Task Delete(Product request, CancellationToken cancellationToken) => _context.Product.Remove(request);        

        public async Task<Product?> Exists(Product Product, CancellationToken cancellationToken)
        {
            return await _context.Product.FindAsync(Product, cancellationToken);
        }

        public async Task Update(Product request, CancellationToken cancellationToken) => _context.Product.Update(request);
    }
}
