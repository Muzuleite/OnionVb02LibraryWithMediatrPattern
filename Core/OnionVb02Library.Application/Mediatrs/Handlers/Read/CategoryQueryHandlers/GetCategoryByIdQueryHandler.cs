using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Queries.CategoryQueries;
using OnionVb02Library.Application.Mediatrs.Results.CategoryResults;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Read.CategoryQueryHandlers
{

    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
    {
        private readonly ICategoryRepository _repository;

        private readonly IMapper _mapper;


        public GetCategoryByIdQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetCategoryByIdQueryResult>(entity);
        }
    }
}
