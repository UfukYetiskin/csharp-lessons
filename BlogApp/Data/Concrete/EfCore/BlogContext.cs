using Microsoft.EntityFrameworkCore;
using BlogApp.Entity;

namespace BlogApp.Data.Concrete.EfCore
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        // DbSet<T> nesnelerini doğrudan tanımlıyoruz, new DbSet<T>() kullanmıyoruz.
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; } 
    }
}
