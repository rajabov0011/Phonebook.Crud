using System;
namespace Phonebook.Crud.Brokers
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(Exception exception);
    }
}
