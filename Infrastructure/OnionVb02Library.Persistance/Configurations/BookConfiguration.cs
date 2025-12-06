using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionVb02Library.Domain.Models;

namespace OnionVb02Library.Persistence.Configurations
{
    public class BookConfiguration : BaseConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Price).HasColumnType("money");
        }
    }

}
