namespace OnionVb02Library.Domain.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
       
        // Navigation
        public virtual ICollection<BookTag> BookTags { get; set; }
    }

}
