using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Queries.TagQueries;
using OnionVb02Library.Application.Mediatrs.Results.TagResults;
using OnionVb02Library.Contract.RepositoryInterfaces;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Read.TagQueryHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        private readonly ITagRepository _repository;

        private readonly IMapper _mapper;
        public GetTagQueryHandler(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<List<GetTagQueryResult>>(entities);
        }
    }
}