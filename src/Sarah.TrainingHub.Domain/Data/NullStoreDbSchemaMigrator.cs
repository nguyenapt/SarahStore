﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Sarah.TrainingHub.Data;

/* This is used if database provider does't define
 * IStoreDbSchemaMigrator implementation.
 */
public class NullStoreDbSchemaMigrator : IStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
