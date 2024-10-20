using CrossCutting;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.Commands.CreateClient
{
    public class CreateClientCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public long CPF { get; set; }
    }
}
