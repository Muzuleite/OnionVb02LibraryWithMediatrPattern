using MediatR;
using OnionVb02Library.Application.Mediatrs.Results.TagResults;

namespace OnionVb02Library.Application.Mediatrs.Queries.TagQueries
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public int Id { get; set; }
        public GetTagByIdQuery(int id) { Id = id; }
    }
}