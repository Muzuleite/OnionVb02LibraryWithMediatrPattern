using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Application.Mediatrs.Results.AuthorResults
{
    public class GetAuthorByIdQueryResult
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}