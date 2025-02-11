using AutoMapper;
using Sarah.Store.Entities;
using Sarah.Store.Services.Subjects;

namespace Sarah.Store;

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
