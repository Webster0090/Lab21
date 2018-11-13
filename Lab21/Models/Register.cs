using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Lab21.Models 
{
    public class Register
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"^([0-9]{3})(|-|())([0-9]{3})(|-|())([0-9]{4})$")]
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}$")]
        public string ZipCode { get; set; }
        [Required]
        [RegularExpression(@"^([0-9A-z]{5,30})(@[0-9A-z]{5,10}).([0-9A-z]{2,3})$")]
        public string EmailAddress { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]{5,}$")]
        public string Password { get; set; }
        public Register()
        {
            FirstName = "";
            LastName = "";
            PhoneNumber = "";
            ZipCode = "";
            EmailAddress = "";
            Password = "";
        }
        public Register(string fn, string ln, string pn, string zc, string ea, string pw)
        {
            FirstName = fn;
            LastName = ln;
            PhoneNumber = pn;
            ZipCode = zc;
            EmailAddress = ea;
            Password = pw;
        }
    }
}
