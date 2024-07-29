using System;
// System.ComponentModel.DataAnnotations.Schema is used to specify the database schema.
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApi;

public class Book
{
    // DatabaseGenerated attribute is used to specify how the database generates values for a property. 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = 0;
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public int Year { get; set; } = 0;

    public Book(){}

    public Book(int id, string title, string author, int year, string genre)
    {
        Id = id;
        Title = title;
        Author = author;
        Year = year;
        Genre = genre;
    }
}