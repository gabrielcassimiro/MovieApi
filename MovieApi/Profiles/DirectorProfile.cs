using AutoMapper;
using MovieApi.Models;
using MovieApi.Models.InputModel;

namespace MovieApi.Profiles
{
    public class DirectorProfile : Profile
    {
        public DirectorProfile()
        {
            CreateMap<Director, DirectorInputModel>().ReverseMap();
        }
    }
}