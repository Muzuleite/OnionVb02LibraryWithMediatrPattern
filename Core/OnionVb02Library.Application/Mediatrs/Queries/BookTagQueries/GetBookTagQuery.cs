using MediatR;
using OnionVb02Library.Application.Mediatrs.Results.BookTagResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Application.Mediatrs.Queries.BookTagQueries
{
    public class GetBookTagQuery : IRequest<List<GetBookTagQueryResult>> { }
}
