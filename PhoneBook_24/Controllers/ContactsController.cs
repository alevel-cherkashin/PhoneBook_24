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
        public ActionResult Add(Contact model)
        {
            if (ModelState.IsValid)
            {
                ContactService.Create(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
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
    }
}