using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02Library.Application.Mediatrs.Commands.BookTagCommands;
using OnionVb02Library.Application.Mediatrs.Queries.BookTagQueries;

namespace OnionVb02Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTagMediatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookTagMediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BookTagList()
        {
            var values = await _mediator.Send(new GetBookTagQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBookTag(CreateBookTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("BookTag oluşturuldu");
        }

        [HttpDelete("{bookId}/{tagId}")]
        public async Task<IActionResult> DeleteBookTag(int bookId, int tagId)
        {
            await _mediator.Send(new RemoveBookTagCommand(bookId, tagId));
            return Ok("BookTag silindi");
        }
    }
}
