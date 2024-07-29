using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApi.DBOperations
{
    public static class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new BookStoreDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>());

            if (context.Books.Any())
                return;   // Data was already seeded

            context.Books.AddRange(
                new Book
                {
                    // Id = 1,
                    Title = "Book 1",
                    Author = "Author 1",
                    Year = 2000,
                    Genre = "Genre 1"
                },
                new Book
                {
                    //Id = 2,
                    Title = "Book 2",
                    Author = "Author 2",
                    Year = 2001,
                    Genre = "Genre 2"
                });

            context.SaveChanges();
        }
    }
}
