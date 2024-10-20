using Application.Product.Commands.CreateClient;
using Application.Product.Commands.CreateProduct;
using Application.Product.Query.GetById;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers.v1.Clients
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class ClientController : Controller
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(IEnumerable<ValidationFailure>), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateClient([FromBody] CreateClientCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);

            if (result.Succeeded)
                return Created("", result.Data);

            return BadRequest(result.Errors);
        }
    }
}
