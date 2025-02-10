using Microsoft.Extensions.Localization;
using Sarah.Store.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Sarah.Store;

[Dependency(ReplaceServices = true)]
public class StoreBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<StoreResource> _localizer;

    public StoreBrandingProvider(IStringLocalizer<StoreResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
