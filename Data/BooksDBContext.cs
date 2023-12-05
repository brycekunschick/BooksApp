using BooksApp_Sec02.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksApp_Sec02.Data
{
    public class BooksDBContext : DbContext
    {

        public BooksDBContext(DbContextOptions<BooksDBContext> options) 
            : base (options)
        { 
        
        
        }

        //add the book table to the database using a DbSet object
        public DbSet<Book> books { get; set; }

        //method that will be called upon when the model is created initially
        //protected: access modifier that only allows this child class access to this method
        //override: we are overriding the parent class's implementation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                
                new Book
                {
                    BookID = 1,
                    Title = "C# for Beginners",
                    Description = "This has no description",
                    Author = "Salman Nazir",
                    Genre = "Coding",
                    Price = 19.99m,
                    DatePublished = new DateTime(2023, 10, 20)
                },

                new Book
                {
                    BookID = 2,
                    Title = "Advanced C#",
                    Description = "This has no description",
                    Author = "Adam Freeman",
                    Genre = "Coding",
                    Price = 59.99m,
                    DatePublished = new DateTime(2022, 10, 11)
                },

                new Book
                {
                    BookID = 3,
                    Title = "HTML for Beginners",
                    Description = "This has no description",
                    Author = "Morgan Freeman",
                    Genre = "Coding",
                    Price = 15.99m,
                    DatePublished = new DateTime(2020, 10, 10)
                }

                );
        }


    }
}
