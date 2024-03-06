using Phonebook.Crud.Models;

namespace Phonebook.Crud.Brokers.Storages
{
    internal interface IStorageBroker
    {
        Contact AddContact(Contact contact);
    }
}
