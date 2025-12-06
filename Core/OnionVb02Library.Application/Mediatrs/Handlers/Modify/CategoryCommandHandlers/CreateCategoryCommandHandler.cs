using AutoMapper;
using MediatR;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Enums;
using OnionVb02Library.Domain.Models;


namespace OnionVb02Library.Application.Mediatrs.Handlers.Modify.CategoryCommandHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _repository;

        private readonly IMapper _mapper;
        public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Category>(request);
            await _repository.CreateAsync(entity);
        }
    }

    
}
