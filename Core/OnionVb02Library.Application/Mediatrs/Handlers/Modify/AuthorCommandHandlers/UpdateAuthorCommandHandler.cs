using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Exceptions;
using OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.AuthorCommandHandlers
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public UpdateAuthorCommandHandler(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            Author author = await _repository.GetByIdAsync(request.Id);

            _mapper.Map(request, author);

            if (author == null)
            {
                throw new NotFoundException("Güncellemeye çalıştığınız yazar bulunamadı.");
            }

            author.UpdatedDate = DateTime.Now;
            author.Status = DataStatus.Updated;

            await _repository.SaveChangesAsync();
        }
    }

}
