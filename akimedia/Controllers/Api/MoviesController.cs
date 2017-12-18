using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Http;
using akimedia.Dtos;
using akimedia.Models;
using AutoMapper;

namespace akimedia.Controllers.Api
{
    public class MoviesController : ApiController
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);
        }

        [HttpPut]
        [Route("api/Movies/{id:int}/{rating:int}")]
        public IHttpActionResult UpdateRating(int id, int rating)
        {
            var movieInDb = _context.Movies.Single(m => m.Id == id);

            var newRating = (movieInDb.Rating * movieInDb.RatedBy + rating) / (movieInDb.RatedBy + 1);
            Console.WriteLine("Люблю сосать жопу, а вышло " + newRating);

            movieInDb.Rating = (byte?)newRating;
            movieInDb.RatedBy += 1;

            _context.SaveChanges();

            return Ok();
        }
        
    }
}
