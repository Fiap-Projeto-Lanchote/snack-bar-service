using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.Query.GetByCategory
{
    public class GetProductByCategoryViewModel
    {
        public GetProductByCategoryViewModel(IEnumerable<Produto> produtos)
        {
            listaProdutos = produtos;
        }

        public IEnumerable<Produto> listaProdutos { get; set; }
    }
}
