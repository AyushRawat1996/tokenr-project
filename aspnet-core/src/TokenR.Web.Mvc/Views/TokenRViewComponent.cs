using Abp.AspNetCore.Mvc.ViewComponents;

namespace TokenR.Web.Views
{
    public abstract class TokenRViewComponent : AbpViewComponent
    {
        protected TokenRViewComponent()
        {
            LocalizationSourceName = TokenRConsts.LocalizationSourceName;
        }
    }
}
