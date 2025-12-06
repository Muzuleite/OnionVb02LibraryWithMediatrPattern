using Microsoft.EntityFrameworkCore;
using OnionVb02Library.Domain.Models;
using OnionVb02Library.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Persistence.ContextClasses
{
    public class MyContext :DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new BookTagConfiguration());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BookTag> BookTags { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
