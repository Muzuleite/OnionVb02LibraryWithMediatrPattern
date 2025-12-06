using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Queries.AuthorQueries;
using OnionVb02Library.Application.Mediatrs.Results.AuthorResults;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Read.AuthorQueryHandlers
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public GetAuthorByIdQueryHandler(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetAuthorByIdQueryResult>(entity);
        }
    }
}
