using System;
using System.ComponentModel.DataAnnotations;
using Sarah.Store.Enumaration;
using Volo.Abp.Application.Dtos;

namespace Sarah.Store.Services.Subjects;

public class SubjectDto : EntityDto<Guid>
{    
    public string Name { get; set; }
        
    public string Description { get; set; }
    public bool? IsDeactive { get; set; }
}