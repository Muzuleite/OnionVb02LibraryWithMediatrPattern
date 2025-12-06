using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Commands.TagCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;


namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.TagCommandHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly ITagRepository _repository;

        private readonly IMapper _mapper;
        public CreateTagCommandHandler(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Tag>(request);
            await _repository.CreateAsync(entity);
        }
    }
}