using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Commands.BookCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.BookCommandHandlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand>
    {
        private readonly IBookRepository _repository;

        private readonly IMapper _mapper;


        public CreateBookCommandHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Book>(request);
            await _repository.CreateAsync(entity);
        }
    }
}
