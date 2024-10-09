using Microsoft.EntityFrameworkCore;
using WebApiService.Models;

namespace WebApiService.Data{
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Post> Posts {get; set;}
        public DbSet<User> Users {get; set;}   
    }
}