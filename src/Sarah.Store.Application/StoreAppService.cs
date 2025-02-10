using Sarah.Store.Localization;
using Volo.Abp.Application.Services;

namespace Sarah.Store;

/* Inherit your application services from this class.
 */
public abstract class StoreAppService : ApplicationService
{
    protected StoreAppService()
    {
        LocalizationResource = typeof(StoreResource);
    }
}
