using System.Web;
using System.Web.Mvc;

namespace Offline.Controllers
{
    public class OfflineController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            this.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            return View();
        }

        public ActionResult Fallback()
        {
            return View();
        }

        public ActionResult Manifest()
        {
            string viewName = "Manifest";

            this.Response.ContentType = "text/cache-manifest";
            this.Response.Cache.SetCacheability(HttpCacheability.NoCache);

#if DEBUG
            viewName = "Manifest-Debug";
#endif

            return View(viewName);

        }
    }
}
