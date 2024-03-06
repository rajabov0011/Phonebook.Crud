using Phonebook.Crud.Models;

namespace Phonebook.Crud.Services.Contacts
{
    internal interface IContactService
    {
        Contact addContact(Contact contact);
    }
}
