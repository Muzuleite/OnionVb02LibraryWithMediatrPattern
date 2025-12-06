using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Domain.Models
{
    public class Author:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //Relational
        public virtual ICollection<Book> Books { get; set; }
    }

}
