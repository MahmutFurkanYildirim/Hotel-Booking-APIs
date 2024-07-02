using AutoMapper;
using BookingProject.EntityLayer.Concrete;
using BookingProject.WebUI.Dtos.AboutDto;
using BookingProject.WebUI.Dtos.LoginDto;
using BookingProject.WebUI.Dtos.RegisterDto;
using BookingProject.WebUI.Dtos.ServiceDto;

namespace BookingProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, User>().ReverseMap();
            CreateMap<LoginUserDto, User>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

        }
    }
}
