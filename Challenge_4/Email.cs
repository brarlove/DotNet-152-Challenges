using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class Email
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string SendEmail { get; set; }

        //Constructor
        public Email(string firstName, string lastName, string type, string sendEmail)
        {
            FirstName = firstName;
            LastName = lastName;
            Type = type;
            SendEmail = sendEmail;
        }
    }
}
