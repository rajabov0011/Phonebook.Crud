using System;
using Phonebook.Crud.Brokers;

namespace Phonebook.Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception customException = new Exception(message: "Custom error message");
            ILoggingBroker loggingBroker = new LoggingBroker();
            loggingBroker.LogInformation("Information message");
            loggingBroker.LogError(customException);
        }
    }
}
