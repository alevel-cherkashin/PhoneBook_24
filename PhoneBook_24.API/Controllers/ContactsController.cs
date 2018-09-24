using PhoneBook_24.BusinessLogic.Models;
using PhoneBook_24.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhoneBook_24.API.Controllers
{
    public class ContactsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            var contacts = ContactService.GetAll();

            return contacts;
        }

        [HttpGet]
        public Contact Get(int id)
        {
            var contacts = ContactService.Get(id);

            return contacts;
        }

        [HttpPost]
        public void Create(Contact contact)
        {
            ContactService.Create(contact);
        }
    }
}
