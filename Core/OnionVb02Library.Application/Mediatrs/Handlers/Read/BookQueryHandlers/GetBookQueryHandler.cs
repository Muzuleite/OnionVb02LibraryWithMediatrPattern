using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Queries.BookQueries;
using OnionVb02Library.Application.Mediatrs.Results.BookResults;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Read.BookQueryHandlers
{
    public class GetBookQueryHandler
        : IRequestHandler<GetBookQuery, List<GetBookQueryResult>>
    {
        private readonly IBookRepository _repository;

        private readonly IMapper _mapper;
        public GetBookQueryHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetBookQueryResult>> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<List<GetBookQueryResult>>(entities);
        }
    }
}
