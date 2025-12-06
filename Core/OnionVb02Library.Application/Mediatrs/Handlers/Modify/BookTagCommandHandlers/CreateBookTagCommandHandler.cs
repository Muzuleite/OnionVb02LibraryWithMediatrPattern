using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Commands.BookTagCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;


namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.BookTagCommandHandlers
{
    public class CreateBookTagCommandHandler : IRequestHandler<CreateBookTagCommand>
    {
        private readonly IBookTagRepository _repository;

        private readonly IMapper _mapper;

        public CreateBookTagCommandHandler(IBookTagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task Handle(CreateBookTagCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<BookTag>(request);
            await _repository.CreateAsync(entity);
        }
    }
}