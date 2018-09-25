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

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Contact contact)
        {
            if (ModelState.IsValid)
            {
                ContactService.Create(contact);
                return RedirectToAction("AddPhone","Phones",contact);
            }
            else
            {
                return View(contact);
            }
        }

        public ActionResult ContactPhones(int id)
        {
            var contact = ContactService.Get(id);

            return View(contact);
        }

        public ActionResult Update(int id, string email)
        {
            var contact = ContactService.Get(id);

            return View(contact);
        }

        [HttpPost]
        public ActionResult Update(Contact contact)
        {
            if (ModelState.IsValid)
            {
                ContactService.Update(contact);

                return RedirectToAction("Index");
            }
            else
            {
                return View(contact);
            }
        }

        public ActionResult Delete(int id)
        {
            ContactService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}