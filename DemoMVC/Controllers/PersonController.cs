using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /Person/
        public IActionResult Index()
        {
            return View();
        } 
        public string Halo()
        {
            return "Nguyen Duy Dat";
        }

        [HttpPost]
        public IActionResult Index(Person ps){
            string add ="Thành Viên" + ps.id + " " + ps.Name +" " + ps.Gender +" "+ ps.email;
            ViewBag.inforPerson = add;
            return View();
        }
    }
}