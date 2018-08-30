namespace ECommerce.Controllers
{
    using ECommerce.Models;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        ECommerceContext db = new ECommerceContext();

        public ActionResult Index()
        {
            var user = db.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
            return View(user);
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