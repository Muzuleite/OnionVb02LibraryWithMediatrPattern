using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02Library.Application.Mediatrs.Commands.TagCommands;
using OnionVb02Library.Application.Mediatrs.Queries.TagQueries;

namespace OnionVb02Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagMediatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagMediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagList()
        {
            var values = await _mediator.Send(new GetTagQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTag(int id)
        {
            var value = await _mediator.Send(new GetTagByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Etiket oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Etiket güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(int id)
        {
            await _mediator.Send(new RemoveTagCommand(id));
            return Ok("Etiket silindi");
        }
    }
}
