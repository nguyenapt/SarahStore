using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Sarah.Store.Entities;

[Table("Course")]
public class Course : Entity<Guid>
{
    [StringLength(100)]
    public string Code { get; set; }
    [StringLength(100)]
    public string Name { get; set; }
    [StringLength(1000)]
    public string Description { get; set; }
    public bool? IsDeactive { get; set; }    
    
}