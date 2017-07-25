using System.Threading.Tasks;
using System.Web.Mvc;
using WashBath.Protal.Web;

namespace WashBath.Protal.Controllers
{
    public class HomeController : PortalController
    {
        public async Task<ActionResult> Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}