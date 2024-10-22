using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.Query.GetById
{
    public class GetProductByIdViewModel
    {
        public GetProductByIdViewModel(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
