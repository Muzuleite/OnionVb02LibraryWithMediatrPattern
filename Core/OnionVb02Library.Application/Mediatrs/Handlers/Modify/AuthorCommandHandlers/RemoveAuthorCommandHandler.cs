using MediatR;
using OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.AuthorCommandHandlers
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommand>
    {
        private readonly IAuthorRepository _repository;

        public RemoveAuthorCommandHandler(IAuthorRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
        {
            Author value = await _repository.GetByIdAsync(request.Id);
            value.Status = DataStatus.Deleted;
            value.DeletedDate = DateTime.Now;

            await _repository.DeleteAsync(value);
        }
    }

}
