using Phonebook.Crud.Models;

namespace Phonebook.Crud.Brokers.Storages
{
    internal interface IStorageBroker
    {
        Contact AddContact(Contact contact);
        Contact[] ReadAllContacts();
        Contact UpdateContact(Contact contact);
        bool DeleteContactById(int id);
    }
}
