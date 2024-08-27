using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    
        [HttpPost]
        public IActionResult Index(string Fullname,string Address)
        {
            string strResult = "Hello " + Fullname + " - " + Address;
            ViewBag.thongBao = strResult;
            return View();
        }
    }
}
