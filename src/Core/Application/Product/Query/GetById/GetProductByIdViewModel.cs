using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.Query.GetById
{
    public class GetProductByIdViewModel
    {
        public GetProductByIdViewModel(Produto produto)
        {
            Id = produto.Id;
            Nome = produto.Nome;
            FkCategoria = produto.FkCategoria;
        }

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public int FkCategoria { get; set; }
    }
}
