using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TokenR.Controllers;

namespace TokenR.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : TokenRControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
