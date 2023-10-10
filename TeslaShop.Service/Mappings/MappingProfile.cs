using AutoMapper;
using TeslaShop.Domain.Models;
using TeslaShop.Service.DTOs.Users;

namespace TeslaShop.Service.Mappings;

public class MappingProfile : Profile
{
    public static IMapper Initialize()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<User, UserForResultDto>().ReverseMap();
            cfg.CreateMap<User, UserForCreationDto>().ReverseMap(); 
            cfg.CreateMap<User, UserForUpdateDto>().ReverseMap();
        });
        return config.CreateMapper();
    }
}
