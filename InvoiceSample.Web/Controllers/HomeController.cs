using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace InvoiceSample.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : InvoiceSampleControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}