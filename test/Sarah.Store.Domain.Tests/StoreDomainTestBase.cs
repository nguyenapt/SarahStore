﻿using Volo.Abp.Modularity;

namespace Sarah.Store;

/* Inherit from this class for your domain layer tests. */
public abstract class StoreDomainTestBase<TStartupModule> : StoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
