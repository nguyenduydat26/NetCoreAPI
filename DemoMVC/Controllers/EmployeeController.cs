using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DemoMVCDemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
    