using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using akimedia.Dtos;
using akimedia.Models;
using AutoMapper;

namespace akimedia.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();
            CreateMap<Director, DirectorDto>();
            CreateMap<DirectorDto, Director>();
        }
    }
}