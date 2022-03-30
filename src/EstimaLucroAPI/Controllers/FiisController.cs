using EstimaLucroAPI.Application.Commands.GetAllFiis;
using EstimaLucroAPI.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstimaLucroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiisController : ControllerBase
    {
        private readonly ILogger<FiisController> _logger;
        private readonly IMediator _mediator;

        public FiisController(ILogger<FiisController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Fii>>> GetAll()
        {
            try
            {
                var response = await _mediator.Send(new GetAllFiisCommand());
                return Ok(response.Fiis);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
