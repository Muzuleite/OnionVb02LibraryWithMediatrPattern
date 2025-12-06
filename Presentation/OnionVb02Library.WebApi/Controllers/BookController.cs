using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02Library.Application.Mediatrs.Commands.BookCommands;
using OnionVb02Library.Application.Mediatrs.Queries.BookQueries;

namespace OnionVb02Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookMediatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookMediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BookList()
        {
            var values = await _mediator.Send(new GetBookQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var value = await _mediator.Send(new GetBookByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kitap oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBookCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kitap güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _mediator.Send(new RemoveBookCommand(id));
            return Ok("Kitap silindi");
        }
    }
}
