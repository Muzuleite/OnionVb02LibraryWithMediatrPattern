using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Exceptions;
using OnionVb02Library.Application.Mediatrs.Commands.TagCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;


namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.TagCommandHandlers
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly ITagRepository _repository;


        private readonly IMapper _mapper;
        public UpdateTagCommandHandler(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Tag>(request);

            if (entity == null)
            {
                throw new NotFoundException("Güncellemeye çalıştığınız tag bulunamadı.");
            }
            _mapper.Map(request, entity);

            entity.UpdatedDate= DateTime.Now;
            entity.Status = DataStatus.Updated;
            await _repository.CreateAsync(entity);
        }
    }
}