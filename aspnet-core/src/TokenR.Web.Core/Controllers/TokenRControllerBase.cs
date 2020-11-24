using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TokenR.Controllers
{
    public abstract class TokenRControllerBase: AbpController
    {
        protected TokenRControllerBase()
        {
            LocalizationSourceName = TokenRConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
