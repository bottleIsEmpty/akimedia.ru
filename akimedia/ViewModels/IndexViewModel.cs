using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using akimedia.Models;

namespace akimedia.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}