using AutoMapper;
using MovieApi.Models;
using MovieApi.Models.InputModel;
using MovieApi.Models.ViewModel;

namespace MovieApi.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieInputModel>().ReverseMap();
            CreateMap<Movie, MovieViewModel>().ReverseMap();
        }
    }
}