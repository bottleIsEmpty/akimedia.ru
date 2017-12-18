using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using akimedia.Models;

namespace akimedia.ViewModels
{
    public class EditMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}