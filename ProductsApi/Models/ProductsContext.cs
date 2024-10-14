using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProductsApi.Models
{
    public class ProductsContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }

        //Statik olarak veri eklemek istersek basit yöntem
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, ProductName = "IPhone 11", Price = 11000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 2, ProductName = "IPhone 12", Price = 12000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, ProductName = "IPhone 13", Price = 13000, IsActive = false });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 4, ProductName = "IPhone 14", Price = 14000, IsActive = false });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 5, ProductName = "IPhone 15", Price = 15000, IsActive = true });

        }
        public DbSet<Product> Products { get; set; }
    }
}