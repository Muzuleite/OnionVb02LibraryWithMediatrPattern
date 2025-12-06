using MediatR;
using OnionVb02Library.Application.Mediatrs.Results.CategoryResults;
using System.Collections.Generic;

namespace OnionVb02Library.Application.Mediatrs.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery : IRequest<GetCategoryByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
