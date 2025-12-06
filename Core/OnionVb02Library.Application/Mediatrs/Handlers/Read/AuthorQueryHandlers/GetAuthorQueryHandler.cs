using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Queries.AuthorQueries;
using OnionVb02Library.Application.Mediatrs.Results.AuthorResults;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Read.AuthorQueryHandlers
{
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IAuthorRepository _repository;

        private readonly IMapper _mapper;

        public GetAuthorQueryHandler(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<List<GetAuthorQueryResult>>(entities);
        }
    }
}
