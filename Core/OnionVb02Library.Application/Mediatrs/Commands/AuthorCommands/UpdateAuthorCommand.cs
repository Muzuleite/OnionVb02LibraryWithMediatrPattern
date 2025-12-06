using MediatR;

namespace OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands
{
    public class UpdateAuthorCommand : IRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}