using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;
using OnionVb02Library.Persistence.ContextClasses;

namespace OnionVb02Library.Persistence.RepositoryConcretes
{
    public class TagRepository(MyContext context) : BaseRepository<Tag>(context), ITagRepository
    {

    }

}
