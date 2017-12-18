using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace akimedia.Models
{
    public class Music
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Название")]
        public string Title { get; set; }

        public Musician Musician { get; set; }

        [Required]
        [Display(Name = "Исполнитель")]
        public int MusicianId { get; set; }

        [Display(Name = "Альбом")]
        public string Album { get; set; }

        [Required]
        [Display(Name = "Дата выхода")]
        public System.DateTime DateReleased { get; set; }

        [Display(Name = "Постер")]
        public string Poster { get; set; }

        [Display(Name = "Жанры")]
        public IList<MusGenre> Genres { get; set; }

        [Display(Name = "Рейтинг")]
        [DefaultValue(0)]
        public byte? Rating { get; set; }

        [Display(Name = "Оценило")]
        [DefaultValue(0)]
        public int? RatedBy { get; set; }

        public Music()
        {
            Genres = new List<MusGenre>();
        }
    }
}