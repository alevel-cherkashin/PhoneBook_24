using PhoneBook_24.BusinessLogic.Models;
using PhoneBook_24.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phonebook24.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {
            var contacts = ContactService.GetAll();

            return View(contacts);
        }

        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Add(Contact model)
        {
            ContactService.Create(model);
            return RedirectToAction("Index");
        }

        public ActionResult PhoneNumber(int id)
        {
            var phone = ContactService.Get(id);
            return View(phone);
        }

        public ActionResult Update(int id)
        {
            var contact = ContactService.Get(id);

            return View();
        }
    }
}