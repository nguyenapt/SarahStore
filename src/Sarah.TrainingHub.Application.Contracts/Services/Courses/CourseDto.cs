using System;
using System.ComponentModel.DataAnnotations;
using Sarah.TrainingHub.Enumaration;
using Volo.Abp.Application.Dtos;

namespace Sarah.TrainingHub.Services.Courses;

public class CourseDto : EntityDto<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Thumb { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public bool? IsDeactive { get; set; }
}