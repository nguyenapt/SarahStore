using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Sarah.TrainingHub.Services.Subjects;

public interface ISubjectAppService :
    ICrudAppService< //Defines CRUD methods
        SubjectDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateSubjectDto> //Used to create/update a book
{

}