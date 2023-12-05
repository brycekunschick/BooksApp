using System.ComponentModel.DataAnnotations;

namespace BooksApp_Sec02.Models
{
    public class Book
    {
        [Key]   
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Author { get; set; }

        [DataType(DataType.Date)] //gets rid of the time portion in the create field
        public DateTime DatePublished { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }


        public int Ratings { get; set; }

    }
}
