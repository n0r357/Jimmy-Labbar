using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L3_1.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EmailValidator : ValidationAttribute
    {
        string[] validEmail;

        public EmailValidator(string[] validEmail)
        {
            this.validEmail = validEmail;
        }
        public override bool IsValid(object value)
        {
            for (int i = 0; i < validEmail.Length; i++)
            {
                if (value.ToString().EndsWith(validEmail[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
