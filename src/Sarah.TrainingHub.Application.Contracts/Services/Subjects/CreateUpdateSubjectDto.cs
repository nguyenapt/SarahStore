using System;
using System.ComponentModel.DataAnnotations;
using Sarah.TrainingHub.Enumaration;

namespace Sarah.TrainingHub.Services.Subjects;

public class CreateUpdateSubjectDto
{
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }
    public bool? IsDeactive { get; set; }
}