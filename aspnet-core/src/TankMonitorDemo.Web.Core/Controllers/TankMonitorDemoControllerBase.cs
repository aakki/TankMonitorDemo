using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TankMonitorDemo.Controllers
{
    public abstract class TankMonitorDemoControllerBase: AbpController
    {
        protected TankMonitorDemoControllerBase()
        {
            LocalizationSourceName = TankMonitorDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
