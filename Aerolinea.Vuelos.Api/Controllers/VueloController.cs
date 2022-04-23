using Aerolinea.Vuelos.Application.UseCases.Command.Vuelos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloController : ControllerBase
    {

        private readonly IMediator _mediator;

        public VueloController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateVuelo")]
        public async Task<IActionResult> CreateVuelo([FromBody] CrearVuelosCommand command)
        {
            Guid id = await _mediator.Send(command);

            if (id == Guid.Empty)
                return BadRequest();

            return Ok(id);
        }
    }
}
