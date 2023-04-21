using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Application.DTOs.Movie;
using MovieRental.Application.DTOs.Tag;
using MovieRental.Application.DTOs.User;
using MovieRental.Application.Features.Movie.Requests.Command;
using MovieRental.Application.Features.Movie.Requests.Queries;
using MovieRental.Application.Features.Tag.Requests.Command;
using MovieRental.Application.Features.User.Requests.Command;
using MovieRental.Application.Features.User.Requests.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> Get()
        {
            var users = await _mediator.Send(new GetUserListRequest());
            return Ok(users);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> Get(int id)
        {
            var user = await _mediator.Send(new GetUserRequest() { Id = id});
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateUserDto userDto)
        {
            var command = new CreateUserCommand() { UserDto= userDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UserDto userDto)
        {
            var command = new UpdateUserCommand() { UserDto = userDto };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteUserCommand() { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

        // PUT api/<UserController>/role
        [HttpPut("role/{id}/{role}")]
        public async Task<ActionResult> ChangeRole(int id, int role)
        {
            var command = new ChangeUserRoleCommand() { UserId = id, RoleId = role };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
