using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Application.DTOs.Sell;
using MovieRental.Application.DTOs.Tag;
using MovieRental.Application.Features.Sell.Requests.Command;
using MovieRental.Application.Features.Tag.Requests.Command;

namespace MovieRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SellController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SellDto sellDto)
        {
            var command = new SellCommand() { SellDto = sellDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
