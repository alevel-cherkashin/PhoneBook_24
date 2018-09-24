using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook_24.BusinessLogic.Attributes
{
    class NameCheckingAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {

            if (value == null)
                return true;


            if (value is string name)
            {
                if (name.StartsWith("A"))
                    return true;
            }
            
            return false;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}
