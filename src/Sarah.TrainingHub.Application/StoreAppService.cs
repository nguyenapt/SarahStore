using Sarah.TrainingHub.Localization;
using Volo.Abp.Application.Services;

namespace Sarah.TrainingHub;

/* Inherit your application services from this class.
 */
public abstract class StoreAppService : ApplicationService
{
    protected StoreAppService()
    {
        LocalizationResource = typeof(StoreResource);
    }
}
