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


    }
}
