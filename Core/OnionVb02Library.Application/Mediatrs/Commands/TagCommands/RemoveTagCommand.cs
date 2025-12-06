using MediatR;


namespace OnionVb02Library.Application.Mediatrs.Commands.TagCommands
{
    public class RemoveTagCommand : IRequest
    {
        public RemoveTagCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}