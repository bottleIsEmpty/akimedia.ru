using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace akimedia.Models
{
    public class BookGenre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public IList<Book> Books { get; set; }

        public BookGenre()
        {
            Books = new List<Book>();
        }
    }
}