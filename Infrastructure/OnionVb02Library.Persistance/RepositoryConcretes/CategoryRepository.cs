using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;
using OnionVb02Library.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Persistence.RepositoryConcretes
{
    public class CategoryRepository(MyContext context) : BaseRepository<Category>(context), ICategoryRepository
    {

    }

}
