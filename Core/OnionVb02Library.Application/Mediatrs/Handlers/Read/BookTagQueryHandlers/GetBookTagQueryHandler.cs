using MediatR;
using OnionVb02Library.Application.Mediatrs.Queries.BookTagQueries;
using OnionVb02Library.Application.Mediatrs.Results.BookTagResults;
using OnionVb02Library.Contract.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Application.Mediatrs.Handlers.Read.BookTagQueryHandlers
{
    public class GetBookTagQueryHandler : IRequestHandler<GetBookTagQuery, List<GetBookTagQueryResult>>
    {
        private readonly IBookTagRepository _repository;
        public GetBookTagQueryHandler(IBookTagRepository repository) { _repository = repository; }


        public async Task<List<GetBookTagQueryResult>> Handle(GetBookTagQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllWithJoinAsync();
            return values.Select(x => new GetBookTagQueryResult
            {
                BookId = x.BookId,
                TagId = x.TagId,
                BookTitle = x.Book.Title,
                TagName = x.Tag.Name
            }).ToList();
        }
    }
}
