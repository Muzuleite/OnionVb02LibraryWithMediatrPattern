using MediatR;
using OnionVb02Library.Application.Mediatrs.Results.AuthorResults;

namespace OnionVb02Library.Application.Mediatrs.Queries.AuthorQueries
{
    public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
    {
    }
}