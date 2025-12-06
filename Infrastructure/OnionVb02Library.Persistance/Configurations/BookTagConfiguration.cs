using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Persistence.Configurations
{
    public class BookTagConfiguration : BaseConfiguration<BookTag>
    {

        public override void Configure(EntityTypeBuilder<BookTag> builder)
        {
            base.Configure(builder);

            builder.Ignore(x => x.Id);
            builder.HasKey(x => new
            {
                x.BookId,
                x.TagId
            });
        }
    }

}
