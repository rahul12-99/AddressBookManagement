using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement
{
    internal class AddressBook
    {
        ArrayList list = new ArrayList();
        public Contact CreateContact()
        {
            Console.WriteLine("Plz enter contact details");
            Contact contact = new Contact();
            Console.WriteLine("Plz enter first name of contact");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Plz enter last name of contact");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Plz enter address of contact");
            contact.address = Console.ReadLine();
            Console.WriteLine("Plz enter city of contact");
            contact.city = Console.ReadLine();
            Console.WriteLine("Plz enter state of contact");
            contact.state = Console.ReadLine();
            Console.WriteLine("Plz enter zipCode of contact");
            contact.zipcode = Console.ReadLine();
            Console.WriteLine("Plz enter phoneNumber of contact");
            contact.phoneNumber = Console.ReadLine();
            Console.WriteLine("Plz enter email of contact");
            contact.email = Console.ReadLine();
            return contact;
        }

        public void AddContacts()
        {
            Console.WriteLine("Plz enter how many contacts you want to save");
            int noOfContacts = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < noOfContacts; i++)
            {
                Contact contacts = CreateContact();
                list.Add(contacts);
            }
        }

        public void PrintContacts()
        {
            foreach (Contact contact in list)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
