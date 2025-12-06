using MediatR;

namespace OnionVb02Library.Application.Mediatrs.Commands.BookTagCommands
{
    public class CreateBookTagCommand : IRequest
    {
        public int BookId { get; set; }
        public int TagId { get; set; }
    }
}