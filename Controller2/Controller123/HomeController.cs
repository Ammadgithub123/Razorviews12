using Microsoft.AspNetCore.Mvc;

namespace Controller2.Controller123
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //viewResult, PartialViewsResult, JsonResult 
        }
        public string AZ()
        {
            return "M.AMMAD";
        }
        public int DisplayId(int id)
        {
            return id;
        }
    }
}
