using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;
using OnionVb02Library.Persistence.ContextClasses;

namespace OnionVb02Library.Persistence.RepositoryConcretes
{
    public class BookRepository(MyContext context) : BaseRepository<Book>(context), IBookRepository
    {

    }

}
