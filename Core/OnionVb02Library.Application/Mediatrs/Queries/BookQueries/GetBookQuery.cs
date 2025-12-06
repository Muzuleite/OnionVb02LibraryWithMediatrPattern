using MediatR;
using OnionVb02Library.Application.Mediatrs.Results.BookResults;

namespace OnionVb02Library.Application.Mediatrs.Queries.BookQueries
{
    public class GetBookQuery : IRequest<List<GetBookQueryResult>>
    {
    }

}
