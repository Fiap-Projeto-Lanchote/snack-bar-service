using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggregates
{
    public class Product
    {
        public required Guid Id { get; set; }
        public required string? Name { get; set; }
        public required Guid CategoryId { get; set; }
        public Category? Categoria { get; set; }
    }

    public class Category
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
    }
}
