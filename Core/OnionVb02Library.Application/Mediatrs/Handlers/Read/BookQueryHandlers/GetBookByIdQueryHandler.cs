using AutoMapper;
using MediatR;
using OnionVb02Library.Application.Mediatrs.Queries.BookQueries;
using OnionVb02Library.Application.Mediatrs.Results.BookResults;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Read.BookQueryHandlers
{
    public class GetBookByIdQueryHandler
        : IRequestHandler<GetBookByIdQuery, GetBookByIdQueryResult>
    {
        private readonly IBookRepository _repository;

        private readonly IMapper _mapper;
        public GetBookByIdQueryHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBookByIdQueryResult> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetBookByIdQueryResult>(entity);
        }
    }
}
