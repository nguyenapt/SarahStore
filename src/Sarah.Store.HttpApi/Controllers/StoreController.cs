using Sarah.Store.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sarah.Store.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StoreController : AbpControllerBase
{
    protected StoreController()
    {
        LocalizationResource = typeof(StoreResource);
    }
}
