using AutoMapper;
using WebProgramlamaOdev.EntityLayer.Concreate;
using WebProgramlamaOdev.WebUI.Dtos;

namespace WebProgramlamaOdev.WebUI.Mapping
{

    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<CreateNewHastaDto, Hasta>().ReverseMap();
        }
    }
}
