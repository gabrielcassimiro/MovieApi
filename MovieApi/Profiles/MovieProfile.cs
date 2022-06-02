using AutoMapper;
using MovieApi.Models;
using MovieApi.Models.InputModel;

namespace MovieApi.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieInputModel>().ReverseMap();
        }
    }
}