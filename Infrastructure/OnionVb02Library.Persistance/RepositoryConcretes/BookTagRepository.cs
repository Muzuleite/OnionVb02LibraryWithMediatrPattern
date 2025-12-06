using Microsoft.EntityFrameworkCore;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Domain.Models;
using OnionVb02Library.Persistence.ContextClasses;

namespace OnionVb02Library.Persistence.RepositoryConcretes
{
    public class BookTagRepository(MyContext context)
    : BaseRepository<BookTag>(context), IBookTagRepository
    {
        public async Task<BookTag> GetByCompositeKeyAsync(int bookId, int tagId)
        {
            return await context.BookTags
                .FirstOrDefaultAsync(x => x.BookId == bookId && x.TagId == tagId);
        }

        public async Task RemoveByCompositeKeyAsync(int bookId, int tagId)
        {
            var entity = await GetByCompositeKeyAsync(bookId, tagId);
            if (entity != null)
            {
                context.BookTags.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<BookTag>> GetAllWithJoinAsync()
        {
            return await context.BookTags
                .Include(x => x.Book)
                .Include(x => x.Tag)
                .ToListAsync();
        }
    }
}
