using AutoMapper;
using studentsAPI.Models.Dtos.ClassroomDtos;
using studentsAPI.Models.Entities;

public class ClassroomProfile : Profile
{
    public ClassroomProfile()
    {
        CreateMap<ClassroomDto, Classroom>()
            .ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
        CreateMap<ClassroomDetailDto, Classroom>()
            .ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.Students, opt => opt.MapFrom(src => src.students))
            .ForPath(dest => dest.SchoolSubject, opt => opt.MapFrom(src => src.school_subjects))
            .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
            .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
            .ReverseMap();
         CreateMap<ClassroomCreateDto, Classroom>()
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
        CreateMap<ClassroomUpdateDto, Classroom>()
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
    }
}