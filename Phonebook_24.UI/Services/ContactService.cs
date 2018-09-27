using PhoneBook_24.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Phonebook_24.UI.Services
{
    public interface IContactService
    {
        Task<List<Contact>> GetAll();
    }
    public class ContactService : IContactService
    {
        public async Task<List<Contact>> GetAll()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Properties.Settings.Default.APIRoot);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            List<Contact> contacts = null;
            HttpResponseMessage response = await client.GetAsync("api/contacts");

            if (response.IsSuccessStatusCode)
            {
                contacts = await response.Content.ReadAsAsync<List<Contact>>();
            }
            else
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    
                }
            }

            return contacts;
        }
    }
}