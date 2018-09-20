using PhoneBook_24.BusinessLogic.Models;
using PhoneBook_24.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook_24.Controllers
{
    public class PhonesController : Controller
    {
        // GET: Phones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View("Phones");
        }
        [HttpPost]
        public ActionResult Update(Phone phone)
        {
            ContactService.UpdatePhone(phone);
            return RedirectToAction("Index", "Contacts");
        }
    }
}