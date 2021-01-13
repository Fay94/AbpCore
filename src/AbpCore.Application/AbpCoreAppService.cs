using System;
using System.Collections.Generic;
using System.Text;
using AbpCore.Localization;
using Volo.Abp.Application.Services;

namespace AbpCore
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpCoreAppService : ApplicationService
    {
        protected AbpCoreAppService()
        {
            LocalizationResource = typeof(AbpCoreResource);
        }
    }
}
