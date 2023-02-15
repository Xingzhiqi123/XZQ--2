using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace XZQ.MESIntelligence.Controllers
{
    public abstract class MESIntelligenceControllerBase: AbpController
    {
        protected MESIntelligenceControllerBase()
        {
            LocalizationSourceName = MESIntelligenceConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
