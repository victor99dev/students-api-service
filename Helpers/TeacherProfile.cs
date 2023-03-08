using AutoMapper;
using studentsAPI.Models.Dtos.TeacherDtos;
using studentsAPI.Models.Entities;

namespace studentsAPI.Helpers
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<TeacherDto, Teacher>()
                .ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
                .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
                .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
                .ReverseMap();
            CreateMap<TeacherCreateDto, Teacher>()
                .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
                .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
                .ReverseMap();
            CreateMap<TeacherUpdateDto, Teacher>()
                .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
                .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
                .ReverseMap();
        }
    }
}