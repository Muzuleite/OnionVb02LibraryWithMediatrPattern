using MediatR;
using OnionVb02Library.Application.Mediatrs.Results.CategoryResults;

namespace OnionVb02Library.Application.Mediatrs.Queries.CategoryQueries
{
    public class GetCategoryQuery : IRequest<List<GetCategoryQueryResult>>
    {
    }
}
