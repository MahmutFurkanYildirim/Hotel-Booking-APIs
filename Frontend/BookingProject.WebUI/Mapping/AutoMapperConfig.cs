using AutoMapper;
using BookingProject.EntityLayer.Concrete;
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
        }
    }
}
