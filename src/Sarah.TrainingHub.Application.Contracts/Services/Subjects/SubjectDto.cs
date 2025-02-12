﻿using System;
using System.ComponentModel.DataAnnotations;
using Sarah.TrainingHub.Enumaration;
using Volo.Abp.Application.Dtos;

namespace Sarah.TrainingHub.Services.Subjects;

public class SubjectDto : EntityDto<Guid>
{    
    public string Name { get; set; }
        
    public string Description { get; set; }
    public bool? IsDeactive { get; set; }
}