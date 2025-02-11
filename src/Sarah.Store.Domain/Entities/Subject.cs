using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace Sarah.Store.Entities;

public class Subject : Entity<Guid>
{
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }
    public bool? IsDeactive { get; set; }
}