using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Exceptions;
using OnionVb02Library.Application.Mediatrs.Commands.BookCommands;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.BookCommandHandlers
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IBookRepository _repository;

        private readonly IMapper _mapper;
        public UpdateBookCommandHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            Book book = await _repository.GetByIdAsync(request.Id);

            if (book == null)
            {
                throw new NotFoundException("Güncellemeye çalıştığınız kitap bulunamadı.");
            }
            _mapper.Map(request, book);

            book.UpdatedDate = DateTime.Now;
            book.Status = DataStatus.Updated;

            await _repository.SaveChangesAsync();

        }
    }
}
