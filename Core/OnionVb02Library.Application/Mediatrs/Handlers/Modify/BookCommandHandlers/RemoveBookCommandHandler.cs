using MediatR;
using OnionVb02Library.Application.Mediatrs.Commands.BookCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.BookCommandHandlers
{
    public class RemoveBookCommandHandler : IRequestHandler<RemoveBookCommand>
    {
        private readonly IBookRepository _repository;

        public RemoveBookCommandHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBookCommand request, CancellationToken cancellationToken)
        {
            Book value = await _repository.GetByIdAsync(request.Id);

            value.Status = DataStatus.Deleted;
            value.DeletedDate = DateTime.Now;

            await _repository.DeleteAsync(value);
        }
    }
}
