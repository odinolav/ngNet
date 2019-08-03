using System.Web.Mvc;

namespace ngNet.Web.Controllers.Web
{
    public class BaseController : Controller
    {

        public BaseController()
        {
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            #if (RELEASE != true)
            if (filterContext.ExceptionHandled) return;
            #endif
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult { ViewName = "~/Views/Error/Index.cshtml" };
        }
    }
}