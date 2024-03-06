using System;
namespace Phonebook.Crud.Brokers.Loggings
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(Exception exception);
    }
}
