namespace Zadanie3
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name} {contact.Number}");
        }

        private void DisplayContactDetails(List<Contact> Contacts)
        {
            foreach (Contact contact in Contacts)
            {
                DisplayContactDetails(contact);
            }
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
            DisplayContactDetails(Contacts);
        }

        public void DisplayMachingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactDetails(matchingContacts);
        }
    }
}
