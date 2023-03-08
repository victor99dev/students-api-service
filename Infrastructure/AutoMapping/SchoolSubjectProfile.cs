using AutoMapper;
using studentsAPI.Models.Dtos.SchoolSubjectDtos;
using studentsAPI.Models.Entities;

public class SchoolSubjectProfile  : Profile
{   
    public SchoolSubjectProfile()
    {
        CreateMap<SchoolSubjectDto, SchoolSubject>()
            .ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.TeacherId, opt => opt.MapFrom(src => src.teacher.id))
            .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
            .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
        CreateMap<SchoolSubjectCreateDto, SchoolSubject>()
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.TeacherId, opt => opt.MapFrom(src => src.teacher_id))
            .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
        CreateMap<SchoolSubjectUpdateDto, SchoolSubject>()
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.TeacherId, opt => opt.MapFrom(src => src.teacher))
            .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
    }
}
