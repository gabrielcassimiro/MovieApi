using AutoMapper;
using MovieApi.Models;
using MovieApi.Models.InputModel;
using MovieApi.Models.ViewModel;

namespace MovieApi.Profiles
{
    public class DirectorProfile : Profile
    {
        public DirectorProfile()
        {
            CreateMap<Director, DirectorInputModel>().ReverseMap();
            CreateMap<Director, DirectorViewModel>().ReverseMap();
        }
    }
}