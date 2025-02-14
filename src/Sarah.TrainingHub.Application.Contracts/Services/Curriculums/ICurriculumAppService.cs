using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Sarah.TrainingHub.Services.Curriculums;

public interface ICurriculumAppService :
    ICrudAppService< //Defines CRUD methods
        CurriculumDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateCurriculumDto> //Used to create/update a book
{

}