using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace TokenR.Web.Views
{
    public abstract class TokenRRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TokenRRazorPage()
        {
            LocalizationSourceName = TokenRConsts.LocalizationSourceName;
        }
    }
}
