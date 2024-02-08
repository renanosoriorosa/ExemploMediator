using ExemploMediator.API.Mediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ExemploMediator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdemProducaoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdemProducaoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> IniciarOP(IniciarOrdemProducaoCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        } 
    }
}
