using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02Library.Application.Mediatrs.Queries.CategoryQueries;

namespace OnionVb02Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryMediatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryMediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _mediator.Send(new GetCategoryQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _mediator.Send(new GetCategoryByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kategori oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kategori güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _mediator.Send(new RemoveCategoryCommand(id));
            return Ok("Kategori silindi");
        }
    }
}
