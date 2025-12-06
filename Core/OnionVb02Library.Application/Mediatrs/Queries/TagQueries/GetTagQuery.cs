using MediatR;
using OnionVb02Library.Application.Mediatrs.Results.TagResults;

namespace OnionVb02Library.Application.Mediatrs.Queries.TagQueries
{
    public class GetTagQuery : IRequest<List<GetTagQueryResult>> { }
}