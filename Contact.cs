using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement
{
    internal class Contact
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipcode;
        public string phoneNumber;
        public string email;

        public override string ToString()
        {
            return firstName.ToString() + " " + lastName.ToString() + " " + address.ToString() + " " +
                address.ToString() + " " + city.ToString() + " " + state.ToString() + " " +
                zipcode.ToString() + " " + phoneNumber.ToString() + " " + email.ToString();
        }
    }
}
