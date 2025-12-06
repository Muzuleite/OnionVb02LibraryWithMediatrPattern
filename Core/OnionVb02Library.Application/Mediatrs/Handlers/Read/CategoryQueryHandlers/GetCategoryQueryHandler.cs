using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Queries.CategoryQueries;
using OnionVb02Library.Application.Mediatrs.Results.CategoryResults;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Read.CategoryQueryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        private readonly ICategoryRepository _repository;

        private readonly IMapper _mapper;
        public GetCategoryQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<List<GetCategoryQueryResult>>(entities);

        }
    }
}
