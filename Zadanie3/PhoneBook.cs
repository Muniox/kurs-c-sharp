using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    internal class PhoneBook
    {
        public List<Contact> Contacts {  get; set; }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name} {contact.Number}");
        }

        public void DisplayContact(string number)
        {
            Contact? contact = Contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null) 
            {
                Console.WriteLine("Contact not found");
                return;
            }
            
            DisplayContactDetails(contact);
            
        }

        public void DisplayAllContacts()
        {
            foreach (Contact contact in Contacts)
            {
                DisplayContactDetails(contact);
            }    
        }

        public void DisplayMachingContacts(string searchPhrase)
        {
            List<Contact>? contact = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
        }
    }
}
