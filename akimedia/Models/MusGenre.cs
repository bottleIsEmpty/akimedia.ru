using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace akimedia.Models
{
    public class MusGenre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public IList<Music> Music { get; set; }

        public MusGenre()
        {
            Music = new List<Music>();
        }
    }
}