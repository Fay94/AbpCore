using AbpCore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpCore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpCoreController : AbpController
    {
        protected AbpCoreController()
        {
            LocalizationResource = typeof(AbpCoreResource);
        }
    }
}