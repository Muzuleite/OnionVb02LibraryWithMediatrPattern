using MediatR;
using OnionVb02Library.Application.Mediatrs.Results.AuthorResults;

namespace OnionVb02Library.Application.Mediatrs.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery : IRequest<GetAuthorByIdQueryResult>
    {
        public int Id { get; set; }
        public GetAuthorByIdQuery(int id) => Id = id;
    }
}