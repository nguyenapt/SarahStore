using AutoMapper;
using Sarah.TrainingHub.Entities;
using Sarah.TrainingHub.Services.Subjects;

namespace Sarah.TrainingHub;

public class StoreApplicationAutoMapperProfile : Profile
{
    public StoreApplicationAutoMapperProfile()
    {
        CreateMap<Subject, SubjectDto>();
        CreateMap<CreateUpdateSubjectDto, Subject>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
