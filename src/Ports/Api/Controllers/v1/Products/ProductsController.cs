using Application.Product.Commands.CreateProduct;
using Application.Product.Query.GetById;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers.v1.Products
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator) => _mediator = mediator;

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetProductByIdViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<ValidationFailure>), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetProductById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetProductByIdQuery(id), cancellationToken);

            return Ok(result.Data);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(IEnumerable<ValidationFailure>), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);

            if (result.Succeeded)
                return Created("", result.Data);

            return BadRequest(result.Errors);
        }
    }
}
