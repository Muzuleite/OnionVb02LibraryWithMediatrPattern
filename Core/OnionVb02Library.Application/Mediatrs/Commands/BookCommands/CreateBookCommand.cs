using MediatR;

namespace OnionVb02Library.Application.Mediatrs.Commands.BookCommands
{
    public class CreateBookCommand : IRequest
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

        public List<int> Tags { get; set; }
    }
}
