using AutoMapper;
using Shared.DataTransferObjects;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Company, CompanyDto>()
                .ForCtorParam("FullAddress",
                opt => opt.MapFrom(x =>
                    $"{x.Address} {x.Country}"
                )
            );
        CreateMap<Employee, EmployeeDto>();

        CreateMap<CompanyForCreationDto, Company>();

        CreateMap<EmployeeForCreationDto, Employee>();

        CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();

        CreateMap<CompanyForUpdateDto, Company>();
    }
}
