using AutoMapper;
using WebProgramlamaOdev.EntityLayer.Concreate;
using WebProgramlamaOdev.WebUI.Dtos;
using WebProgramlamaOdev.WebUI.Dtos.LoginDto;
using WebProgramlamaOdev.WebUI.Dtos.RegisterDto;

namespace WebProgramlamaOdev.WebUI.Mapping
{

    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<CreateNewHastaDto, Hasta>().ReverseMap();
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
        }
    }
}
