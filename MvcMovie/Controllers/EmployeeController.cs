using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Fullname, string City)
        {
            string strResult = "Xin chào " + Fullname + "-" + City;
            ViewBag.thongBao = strResult;
            return View();
        }
    }
}