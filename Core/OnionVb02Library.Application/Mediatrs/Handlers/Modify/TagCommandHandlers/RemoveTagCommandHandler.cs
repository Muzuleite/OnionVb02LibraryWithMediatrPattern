using MediatR;
using OnionVb02Library.Application.Mediatrs.Commands.TagCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;


namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.TagCommandHandlers
{
    public class RemoveTagCommandHandler : IRequestHandler<RemoveTagCommand>
    {
        private readonly ITagRepository _repository;

        public RemoveTagCommandHandler(ITagRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            Tag value = await _repository.GetByIdAsync(request.Id);

            value.Status = DataStatus.Deleted;
            value.DeletedDate = DateTime.Now;

            await _repository.DeleteAsync(value);
        }
    }
}