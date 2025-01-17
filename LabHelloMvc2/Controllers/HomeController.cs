using LabHelloMvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace LabHelloMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var person = new Person
            {
                FirstName = "Jacob",
                LastName = "Poirier"
            };

            return View(person);
        }
    }
}
