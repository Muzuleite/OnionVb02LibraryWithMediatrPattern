using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Exceptions;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.CategoryCommandHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly ICategoryRepository _repository;

        private readonly IMapper _mapper;
        public UpdateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException("Güncellemeye çalıştığınız kategori bulunamadı.");
            }

            _mapper.Map(request,entity);

            entity.UpdatedDate = DateTime.Now;
            entity.Status = DataStatus.Updated;
            await _repository.SaveChangesAsync();
        }
    }
}
