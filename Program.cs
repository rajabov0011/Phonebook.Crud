using System;
using Phonebook.Crud.Models;
using Phonebook.Crud.Services.Contacts;

namespace Phonebook.Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContactService contactService = new ContactService();

            Contact contact = new Contact
            {
                Id = 1,
                Name = "John Doe",
                Phone = "123-456-7890"
            };
            contactService.addContact(contact);
        }
    }
}