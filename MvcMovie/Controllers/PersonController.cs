using Microsoft.AspNetCore.Mvc;
namespace MvcMovie.Controllers;
public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Fullname,string Age)
    {
        string strResult = "Hello " + Fullname + "-" + Age;
        ViewBag.thongBao = strResult;
        return View();
    }
}
