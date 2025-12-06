using MediatR;

namespace OnionVb02Library.Application.Mediatrs.Commands.BookCommands
{
    public class RemoveBookCommand : IRequest
    {
        public RemoveBookCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
        
    }
}
