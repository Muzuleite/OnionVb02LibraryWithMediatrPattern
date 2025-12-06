using MediatR;

namespace OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands
{
    public class RemoveAuthorCommand : IRequest
    {
        public RemoveAuthorCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
        
    }
}