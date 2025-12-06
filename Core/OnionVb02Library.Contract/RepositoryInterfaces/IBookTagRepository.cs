using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Contract.RepositoryInterfaces
{
    public interface IBookTagRepository : IRepository<BookTag>
    {
        Task<BookTag> GetByCompositeKeyAsync(int bookId, int tagId);
        Task RemoveByCompositeKeyAsync(int bookId, int tagId);
        Task<List<BookTag>> GetAllWithJoinAsync();
    }
}
