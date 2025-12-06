using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Queries.TagQueries;
using OnionVb02Library.Application.Mediatrs.Results.TagResults;
using OnionVb02Library.Contract.RepositoryInterfaces;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Read.TagQueryHandlers
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly ITagRepository _repository;

        private readonly IMapper _mapper;
        public GetTagByIdQueryHandler(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetTagByIdQueryResult>(entity);
        }
    }
}