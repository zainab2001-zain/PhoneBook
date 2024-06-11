using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_book
{
    class PhoneBook
    {
        private void DisplayContactDetails(Contact contact)
        {

            Console.WriteLine($"Contact: { contact.Name},{ contact.Number}");
        }
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        public void AddContact(Contact contact)
        {

            _contacts.Add(contact);

        }
        public  void DisplayContact(string number)
        {
            var contact=_contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not Found!");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContact()
        {
            DisplayContactsDetails(_contacts);   
        }
        public void DisplayMatchingContacts(string searchphrase)
        {
            var MatchingContacts = _contacts.Where(c=>c.Name.Contains( searchphrase)).ToList();
            DisplayContactsDetails(_contacts);
        }
    }
}
