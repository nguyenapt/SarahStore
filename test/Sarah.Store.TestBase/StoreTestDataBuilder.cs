﻿using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Sarah.Store;

public class StoreTestDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly ICurrentTenant _currentTenant;

    public StoreTestDataSeedContributor(ICurrentTenant currentTenant)
    {
        _currentTenant = currentTenant;
    }

    public Task SeedAsync(DataSeedContext context)
    {
        /* Seed additional test data... */

        using (_currentTenant.Change(context?.TenantId))
        {
            return Task.CompletedTask;
        }
    }
}
