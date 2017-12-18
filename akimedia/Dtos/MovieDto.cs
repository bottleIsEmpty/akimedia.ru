using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using akimedia.Models;

namespace akimedia.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [DefaultValue(0)]
        public byte? Rating { get; set; }

        [DefaultValue(0)]
        public int? RatedBy { get; set; }
    }
}