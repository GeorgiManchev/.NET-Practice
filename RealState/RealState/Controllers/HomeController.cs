using System.Web.Mvc;

namespace RealState.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Contact()
        {
            return View();
        }
    }
}