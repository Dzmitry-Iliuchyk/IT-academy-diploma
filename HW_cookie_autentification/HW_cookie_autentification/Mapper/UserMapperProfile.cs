using AutoMapper;
using HW_cookie_autentification.Models.UserModels;
using HW_cookie_autentification.Models.UserModels.UserDTOs;

namespace HW_cookie_autentification.Mapper
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile() 
        {
            CreateMap<RegisterDTO, User>()
            .ForMember(dest => dest.Password, opt => opt.MapFrom(map => map.Password))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(map => map.Email))
            .ForMember(dest => dest.Role, opt => opt.MapFrom(map => map.Role))
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Phone, opt => opt.Ignore())
            .ForMember(dest => dest.Name, opt => opt.Ignore())
            .ForMember(dest => dest.Description, opt => opt.Ignore());


            CreateMap<User, RegisterDTO>()
            .ForMember(dest => dest.Password, opt => opt.MapFrom(map => map.Password));

          

            CreateMap<LoginDTO, User>().ReverseMap();
                //.ForMember(dest => dest.Password, opt => opt.MapFrom(map => map.Password))
                //.ForMember(dest => dest.Email, opt => opt.MapFrom(map => map.Email))
                //.ForMember(dest => dest.Id, opt => opt.Ignore())
                //.ForMember(dest => dest.Phone, opt => opt.Ignore())
                //.ForMember(dest => dest.Name, opt => opt.Ignore())
                //.ForMember(dest => dest.Description, opt => opt.Ignore()); 
                
        }
    }
}
