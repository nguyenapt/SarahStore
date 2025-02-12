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
using Sarah.TrainingHub.Services.Subjects;

namespace Sarah.TrainingHub.Services;

[Authorize(StorePermissions.Subjects.Default)]
public class SubjectAppService : ApplicationService, ISubjectAppService
{
    private readonly IRepository<Subject, Guid> _repository;

    public SubjectAppService(IRepository<Subject, Guid> repository)
    {
        _repository = repository;
    }

    public async Task<SubjectDto> GetAsync(Guid id)
    {
        var subject = await _repository.GetAsync(id);
        return ObjectMapper.Map<Subject, SubjectDto>(subject);
    }

    public async Task<PagedResultDto<SubjectDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await _repository.GetQueryableAsync();
        var query = queryable
            .OrderBy(input.Sorting.IsNullOrWhiteSpace() ? "Name" : input.Sorting)
            .Skip(input.SkipCount)
            .Take(input.MaxResultCount);

        var subjects = await AsyncExecuter.ToListAsync(query);
        var totalCount = await AsyncExecuter.CountAsync(queryable);

        return new PagedResultDto<SubjectDto>(
            totalCount,
            ObjectMapper.Map<List<Subject>, List<SubjectDto>>(subjects)
        );
    }

    [Authorize(StorePermissions.Subjects.Create)]
    public async Task<SubjectDto> CreateAsync(CreateUpdateSubjectDto input)
    {
        var subject = ObjectMapper.Map<CreateUpdateSubjectDto, Subject>(input);
        await _repository.InsertAsync(subject);
        return ObjectMapper.Map<Subject, SubjectDto>(subject);
    }

    [Authorize(StorePermissions.Subjects.Edit)]
    public async Task<SubjectDto> UpdateAsync(Guid id, CreateUpdateSubjectDto input)
    {
        var subject = await _repository.GetAsync(id);
        ObjectMapper.Map(input, subject);
        await _repository.UpdateAsync(subject);
        return ObjectMapper.Map<Subject, SubjectDto>(subject);
    }

    [Authorize(StorePermissions.Subjects.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}
