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

        [HttpGet]
        public ActionResult UpdatePhones(int Id)
        {
            var phone = ContactService.GetPhone(Id);
            return View(phone);
        }

        [HttpPost]
        public ActionResult UpdatePhones(Phone phone)
        {
            ContactService.UpdatePhone(phone);
            return RedirectToAction("Index", "Contacts");
        }

        [HttpGet]
        public ActionResult AddPhone()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPhone(Phone phone)
        {
            ContactService.CreatePhone();
            ContactService.UpdatePhone(phone);
            return RedirectToAction("Index", "Contacts");
        }
    }
}