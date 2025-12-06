using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands;
using OnionVb02Library.Application.Mediatrs.Queries.AuthorQueries;

namespace OnionVb02Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorMediatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorMediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AuthorList()
        {
            var values = await _mediator.Send(new GetAuthorQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            var value = await _mediator.Send(new GetAuthorByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yazar oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yazar güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            await _mediator.Send(new RemoveAuthorCommand(id));
            return Ok("Yazar silindi");
        }
    }
}
