using Sarah.TrainingHub.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sarah.TrainingHub.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StoreController : AbpControllerBase
{
    protected StoreController()
    {
        LocalizationResource = typeof(StoreResource);
    }
}
