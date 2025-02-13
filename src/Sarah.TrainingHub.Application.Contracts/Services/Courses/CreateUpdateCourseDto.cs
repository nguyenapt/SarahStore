using System;
using System.ComponentModel.DataAnnotations;
using Sarah.TrainingHub.Enumaration;

namespace Sarah.TrainingHub.Services.Courses;

public class CreateUpdateCourseDto
{
    [StringLength(100)]
    public string Code { get; set; }
    [StringLength(255)]
    public string Name { get; set; }

    [StringLength(255)]
    public string? Thumb { get; set; }

    [StringLength(255)]
    public string? Summary { get; set; }

    [StringLength(5000)]
    public string? Description { get; set; }

    public bool? IsDeactive { get; set; }
}