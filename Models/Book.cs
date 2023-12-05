using System.ComponentModel.DataAnnotations;

namespace BooksApp_Sec02.Models
{
    public class Book
    {
        [Key]   
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Author { get; set; }

        [DataType(DataType.Date)] //gets rid of the time portion in the create field
        public DateTime DatePublished { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
}
