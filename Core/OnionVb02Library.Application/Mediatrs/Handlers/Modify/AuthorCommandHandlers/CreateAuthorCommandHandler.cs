using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.AuthorCommandHandlers
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public CreateAuthorCommandHandler(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            Author entity = _mapper.Map<Author>(request);

            entity.CreatedDate = DateTime.Now;
            entity.Status = DataStatus.Inserted;

            await _repository.CreateAsync(entity);
        }
    }

}
