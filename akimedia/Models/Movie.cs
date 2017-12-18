using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace akimedia.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Название")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Тип")]
        public bool Type { get; set; }

        public Director Director { get; set; }

        [Required]
        [Display(Name = "Режиссёр")]
        public int DirectorId { get; set; }

        [Required]
        [Display(Name = "Дата выхода")]
        public DateTime DateReleased { get; set; }

        [Display(Name = "Постер")]
        public string Poster { get; set; }

        [Display(Name = "Жанры")]
        public IList<Genre> Genres { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Рейтинг")]
        [DefaultValue(0)]
        public byte? Rating { get; set; }

        [Display(Name = "Оценило")]
        [DefaultValue(0)]
        public int? RatedBy { get; set; }

        public Movie()
        {
            Genres = new List<Genre>();
        }
    }
}