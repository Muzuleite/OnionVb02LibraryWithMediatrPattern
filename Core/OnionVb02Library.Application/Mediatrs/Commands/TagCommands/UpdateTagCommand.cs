using MediatR;


namespace OnionVb02Library.Application.Mediatrs.Commands.TagCommands
{
    public class UpdateTagCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}