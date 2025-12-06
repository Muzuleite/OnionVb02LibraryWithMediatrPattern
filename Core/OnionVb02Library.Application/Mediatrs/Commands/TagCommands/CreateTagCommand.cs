using MediatR;


namespace OnionVb02Library.Application.Mediatrs.Commands.TagCommands
{
    public class CreateTagCommand : IRequest
    {
        public string Name { get; set; }
    }
}