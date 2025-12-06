namespace OnionVb02Library.Domain.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
       

        // Navigation
        public virtual ICollection<Book> Books { get; set; }
    }

}
