using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Sarah.TrainingHub.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq.Dynamic.Core;
using Sarah.TrainingHub.Entities;
using Sarah.TrainingHub.Services.Courses;

namespace Sarah.TrainingHub.Services;

[Authorize(TrainingHubPermissions.Courses.Default)]
public class CourseAppService : ApplicationService, ICourseAppService
{
    private readonly IRepository<Course, Guid> _repository;

    public CourseAppService(IRepository<Course, Guid> repository)
    {
        _repository = repository;
    }

    public async Task<CourseDto> GetAsync(Guid id)
    {
        var item = await _repository.GetAsync(id);
        return ObjectMapper.Map<Course, CourseDto>(item);
    }

    public async Task<PagedResultDto<CourseDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await _repository.GetQueryableAsync();
        var query = queryable
            .OrderBy(input.Sorting.IsNullOrWhiteSpace() ? "Name" : input.Sorting)
            .Skip(input.SkipCount)
            .Take(input.MaxResultCount);

        var items = await AsyncExecuter.ToListAsync(query);
        var totalCount = await AsyncExecuter.CountAsync(queryable);

        return new PagedResultDto<CourseDto>(
            totalCount,
            ObjectMapper.Map<List<Course>, List<CourseDto>>(items)
        );
    }

    [Authorize(TrainingHubPermissions.Courses.Create)]
    public async Task<CourseDto> CreateAsync(CreateUpdateCourseDto input)
    {
        var item = ObjectMapper.Map<CreateUpdateCourseDto, Course>(input);
        await _repository.InsertAsync(item);
        return ObjectMapper.Map<Course, CourseDto>(item);
    }

    [Authorize(TrainingHubPermissions.Courses.Edit)]
    public async Task<CourseDto> UpdateAsync(Guid id, CreateUpdateCourseDto input)
    {
        var item = await _repository.GetAsync(id);
        ObjectMapper.Map(input, item);
        await _repository.UpdateAsync(item);
        return ObjectMapper.Map<Course, CourseDto>(item);
    }

    [Authorize(TrainingHubPermissions.Courses.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}
