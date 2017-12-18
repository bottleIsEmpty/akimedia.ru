using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using akimedia.Dtos;
using akimedia.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace akimedia.Controllers.Api
{
    public class DirectorsController : ApiController
    {
        private ApplicationDbContext _context;

        public DirectorsController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetDirectors(string query = null)
        {

            IEnumerable<Director> director;

            if (!String.IsNullOrWhiteSpace(query))
            {
                director = _context.Directors
                    .Where(d => d.Name.Contains(query) || d.Surname.Contains(query))
                    .ToList();

            }
            else
            {
                director = _context.Directors
                    .ToList();
            }


            var directorDtos = director.Select(Mapper.Map<Director, DirectorDto>);
            return Ok(directorDtos);

        }

        public IHttpActionResult GetDirector(int id)
        {
            var director = _context.Directors.SingleOrDefault(c => c.Id == id);

            if (director == null)
                return NotFound();

            return Ok(Mapper.Map<Director, DirectorDto>(director));
        }
    }
}
