using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Phonebook_24.UI.Services;

namespace Phonebook_24.UI.Controllers
{
    public class HomeController : Controller
    {
        private IContactService _contactServise = new ContactService();


        public async Task<ActionResult> Index()
        {
            var list = await _contactServise.GetAll();
            return View(list);
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