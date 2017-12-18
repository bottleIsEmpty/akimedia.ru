using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace akimedia.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Название")]
        public string Title { get; set; }

        public Writer Director { get; set; }

        [Required]
        [Display(Name = "Автор")]
        public int WriterId { get; set; }

        [Required]
        [Display(Name = "Дата выхода")]
        public DateTime DateReleased { get; set; }

        [Display(Name = "Постер")]
        public string Poster { get; set; }

        [Display(Name = "Жанры")]
        public IList<BookGenre> Genres { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Рейтинг")]
        [DefaultValue(0)]
        public byte? Rating { get; set; }

        [Display(Name = "Оценило")]
        [DefaultValue(0)]
        public int? RatedBy { get; set; }

        public Book()
        {
            Genres = new List<BookGenre>();
        }
    }
}