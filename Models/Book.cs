using System.ComponentModel.DataAnnotations;

namespace BooksApp_Sec02.Models
{
    public class Book
    {
        [Key]   
        public int Book__ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Author { get; set; }

        public DateTime DatePublished { get; set; }

        public string Genre { get; set; }
    }
}
