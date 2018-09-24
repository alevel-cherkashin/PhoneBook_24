using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook_24.BusinessLogic.Attributes;


namespace PhoneBook_24.BusinessLogic.Models
{
    [Serializable]
    public class Contact
    {
        public int Id { get; set; }

        //[NameChecking(ErrorMessage = "Wring Start letter")]
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
