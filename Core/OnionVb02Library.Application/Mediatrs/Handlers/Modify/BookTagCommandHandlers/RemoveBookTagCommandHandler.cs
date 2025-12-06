using MediatR;
using OnionVb02Library.Application.Mediatrs.Commands.BookTagCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;


namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.BookTagCommandHandlers
{
    public class RemoveBookTagCommandHandler : IRequestHandler<RemoveBookTagCommand>
    {
        private readonly IBookTagRepository _repository;
        public RemoveBookTagCommandHandler(IBookTagRepository repository) { _repository = repository; }


        public async Task Handle(RemoveBookTagCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByCompositeKeyAsync(request.BookId, request.TagId);
        }
    }
}