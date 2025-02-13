using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Sarah.TrainingHub.Services.Courses;

public interface ICourseAppService :
    ICrudAppService< //Defines CRUD methods
        CourseDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateCourseDto> //Used to create/update a book
{

}