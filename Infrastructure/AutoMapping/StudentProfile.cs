using AutoMapper;
using studentsAPI.Models.Dtos.StudentDtos;
using studentsAPI.Models.Entities;

public class StudentProfile : Profile
{
    public StudentProfile()
    {
        CreateMap<StudentDto, Student>()
            .ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
         CreateMap<StudentDetailDto, Student>()
            .ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.date_of_birth))
            .ForPath(dest => dest.Rg, opt => opt.MapFrom(src => src.rg))
            .ForPath(dest => dest.LegalResponsibleName, opt => opt.MapFrom(src => src.legal_responsible_name))
            .ForPath(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.address_street))
            .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
            .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
        CreateMap<StudentCreateDto, Student>()
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.date_of_birth))
            .ForPath(dest => dest.Rg, opt => opt.MapFrom(src => src.rg))
            .ForPath(dest => dest.LegalResponsibleName, opt => opt.MapFrom(src => src.legal_responsible_name))
            .ForPath(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.address_street))
            .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
        CreateMap<StudentUpdateDto, Student>()
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForPath(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.date_of_birth))
            .ForPath(dest => dest.Rg, opt => opt.MapFrom(src => src.rg))
            .ForPath(dest => dest.LegalResponsibleName, opt => opt.MapFrom(src => src.legal_responsible_name))
            .ForPath(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.address_street))
            .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
            .ForPath(dest => dest.IsActive, opt => opt.MapFrom(src => src.is_active))
            .ReverseMap();
    }
}
