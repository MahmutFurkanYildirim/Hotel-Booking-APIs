using AutoMapper;
using BookingProject.DtoLayer.Dtos.RoomDto;
using BookingProject.EntityLayer.Concrete;

namespace BookingProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();
        }
    }
}
