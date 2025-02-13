using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Sarah.TrainingHub.Entities;

[Table("Course")]
public class Course : Entity<Guid>
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