using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L3_1.CustomAttributes
{
    public class EmailHighlighter : ValidationAttribute
    {
        string highlightEmail;

        public EmailHighlighter(string validEmail)
        {
            this.highlightEmail = validEmail;
        }
        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith(highlightEmail);
        }
    }
}
