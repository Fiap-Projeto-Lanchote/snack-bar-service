using Application.Product.Commands.CreateProduct;
using CrossCutting;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product.Commands.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Result>
    {
        public CreateClientCommandHandler()
        {

        }

        public async Task<Result> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            return Result.Success();
        }
    }
}
