using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using akimedia.Models;
using akimedia.ViewModels;
using System.Diagnostics;

namespace akimedia.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //Список всех фильмов
        public ActionResult Index(int page = 1)
        {
            int pageSize = 3;

            IEnumerable<Movie> movies = _context.Movies
                .Include(m => m.Director)
                .Include(m => m.Genres)
                .OrderBy(m => m.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            PageInfo pageInfo = new PageInfo
            {
                PageNumber = page,
                PageSize = pageSize,
                TotalItems = _context.Movies.Count()
            };

            ViewModels.IndexViewModel viewModel = new ViewModels.IndexViewModel
            {
                Movies = movies,
                PageInfo = pageInfo
            };

            return View(viewModel);
        }

        //Вывод страницы создания
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new EditMovieViewModel
            {
                Movie = new Movie(),
                Genres = genres
            };

            return View(viewModel);
        }

        //Создание фильма
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie, int[] genreIds, HttpPostedFileBase image = null)
        {
            if (!ModelState.IsValid)
            {
                var genres = _context.Genres.ToList();
                var viewModel = new EditMovieViewModel
                {
                    Movie  = movie,
                    Genres = genres
                };

                return View("New", viewModel);
            }
                
            if (image != null)
            {
                string fileName = Path.GetFileName(image.FileName);
                image.SaveAs(Server.MapPath("~/Files/" + fileName));

                movie.Poster = fileName;
            }

            if (genreIds != null)
            {
                foreach (var genre in _context.Genres.Where(g => genreIds.Contains(g.Id)))
                {
                    movie.Genres.Add(genre);
                }
            }

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //Детальная информация
        public ActionResult Details(int id)
        {
            var movie = _context.Movies
                .Include(m => m.Director)
                .Include(m => m.Genres)
                .SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);

        }
    }
}