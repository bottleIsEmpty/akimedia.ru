using System.ComponentModel.DataAnnotations;

namespace akimedia.Models
{
    public class Musician
    {
        public int Id { get; set; }

        Types Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        public enum Types
        {
            [Display(Name = "Соло")]
            Solo,
            [Display(Name = "Группа")]
            Band,
            [Display(Name = "Оркестр")]
            Orchestra
        }
    }
}