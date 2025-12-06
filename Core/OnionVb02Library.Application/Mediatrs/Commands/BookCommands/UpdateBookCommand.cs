using MediatR;

namespace OnionVb02Library.Application.Mediatrs.Commands.BookCommands
{
    public class UpdateBookCommand : IRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public decimal Price { get; set; }

        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

        public List<int> Tags { get; set; }
    }
}
