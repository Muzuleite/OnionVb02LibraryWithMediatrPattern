using MediatR;

namespace OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands
{
    public class CreateAuthorCommand : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}