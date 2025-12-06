using MediatR;

namespace OnionVb02Library.Application.Mediatrs.Commands.BookTagCommands
{
    public class RemoveBookTagCommand : IRequest
    {
        public int BookId { get; set; }
        public int TagId { get; set; }
        public RemoveBookTagCommand(int bookId, int tagId) { BookId = bookId; TagId = tagId; }
    }
}