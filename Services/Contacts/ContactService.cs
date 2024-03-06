using Phonebook.Crud.Brokers.Loggings;
using Phonebook.Crud.Brokers.Storages;
using Phonebook.Crud.Models;

namespace Phonebook.Crud.Services.Contacts
{
    internal class ContactService : IContactService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public ContactService()
        {
            this.storageBroker = new FileStorageBroker();
            this.loggingBroker = new LoggingBroker();
        }

        public Contact addContact(Contact contact) =>
            this.storageBroker.AddContact(contact);
    }
}
