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
using Sarah.TrainingHub.Services.Curriculums;

namespace Sarah.TrainingHub.Services;

[Authorize(TrainingHubPermissions.Curriculums.Default)]
public class CurriculumAppService : ApplicationService, ICurriculumAppService
{
    private readonly IRepository<Curriculum, Guid> _repository;

    public CurriculumAppService(IRepository<Curriculum, Guid> repository)
    {
        _repository = repository;
    }

    public async Task<CurriculumDto> GetAsync(Guid id)
    {
        var item = await _repository.GetAsync(id);
        return ObjectMapper.Map<Curriculum, CurriculumDto>(item);
    }

    public async Task<PagedResultDto<CurriculumDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await _repository.GetQueryableAsync();
        var query = queryable
            .OrderBy(input.Sorting.IsNullOrWhiteSpace() ? "Name" : input.Sorting)
            .Skip(input.SkipCount)
            .Take(input.MaxResultCount);

        var items = await AsyncExecuter.ToListAsync(query);
        var totalCount = await AsyncExecuter.CountAsync(queryable);

        return new PagedResultDto<CurriculumDto>(
            totalCount,
            ObjectMapper.Map<List<Curriculum>, List<CurriculumDto>>(items)
        );
    }

    [Authorize(TrainingHubPermissions.Curriculums.Create)]
    public async Task<CurriculumDto> CreateAsync(CreateUpdateCurriculumDto input)
    {
        var item = ObjectMapper.Map<CreateUpdateCurriculumDto, Curriculum>(input);
        await _repository.InsertAsync(item);
        return ObjectMapper.Map<Curriculum, CurriculumDto>(item);
    }

    [Authorize(TrainingHubPermissions.Curriculums.Edit)]
    public async Task<CurriculumDto> UpdateAsync(Guid id, CreateUpdateCurriculumDto input)
    {
        var item = await _repository.GetAsync(id);
        ObjectMapper.Map(input, item);
        await _repository.UpdateAsync(item);
        return ObjectMapper.Map<Curriculum, CurriculumDto>(item);
    }

    [Authorize(TrainingHubPermissions.Curriculums.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}
