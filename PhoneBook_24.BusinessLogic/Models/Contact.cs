using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneBook_24.BusinessLogic.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя не указано!")]
        [MaxLength(length: 15, ErrorMessage = "Слишком длинное имя!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email не указан!")]
        [MaxLength(length: 25, ErrorMessage = "Слишком длинний Email!")]
        [EmailAddress(ErrorMessage = "Не содержит Email!!")]
        public string Email { get; set; }


        public List<Phone> Phones { get; set; }

        public Contact()
        {
            Phones = new List<Phone>();
        }
        

    }
}
