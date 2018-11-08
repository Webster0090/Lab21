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
        [RegularExpression(@"^([0-9A-z]{5,30})(@[0-9A-z]{5,10}).([0-9A-z]{2,3})$")]
        public string emailaddress { get; set; }

        [Required]
        [RegularExpression(@"^(\d{3})-(\d{3})-(\d{4})$")]
        public string PhoneNumber { get; set; }
        
        [Required]
        [RegularExpression(@"^[a-zA-Z]\w{3,14}$")]
        public string Password { get; set; }

        public Register()
        {
            FirstName = "";
            LastName = "";
            emailaddress = "";
            PhoneNumber = "";
            Password = "";
        }
        public Register(string fn, string ln, string ea, string pn, string pw)
        {
            FirstName = fn;
            LastName = ln;
            emailaddress = ea;
            PhoneNumber = pn;
            Password = pw;
        }








    }
}