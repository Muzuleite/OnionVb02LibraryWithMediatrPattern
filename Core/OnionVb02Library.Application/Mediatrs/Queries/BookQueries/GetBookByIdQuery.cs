using MediatR;
using OnionVb02Library.Application.Mediatrs.Results.BookResults;

namespace OnionVb02Library.Application.Mediatrs.Queries.BookQueries
{
    public class GetBookByIdQuery : IRequest<GetBookByIdQueryResult>
    {
        public int Id { get; set; }
        public GetBookByIdQuery(int id) => Id = id;
    }

}
