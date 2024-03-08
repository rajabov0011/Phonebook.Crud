using System;
using Phonebook.Crud.Models;
using Phonebook.Crud.Services.Contacts;

namespace Phonebook.Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            do
            {
                Console.Clear();
                ShowMenu();
                Console.Write("Choose >>> ");
                int myChoose = Convert.ToInt32(Console.ReadLine());
                switch (myChoose)
                {
                    case 1:
                        Console.Clear();
                        IContactService contactService = new ContactService();
                        Console.Write("Enter Id, Name and Phone: ");
                        string[] dataContact = Console.ReadLine().Split(' ');
                        int ID = Convert.ToInt32(dataContact[0]);
                        string name = dataContact[1];
                        string phone = dataContact[2];
                        Contact contact = new Contact
                        {
                            Id = ID,
                            Name = name,
                            Phone = phone
                        };
                        contactService.addContact(contact);
                        Console.Write("Do you want see the result? Enter [yes/no] >>> ");
                        if (Console.ReadLine() == "yes")
                        {
                            Console.Clear();
                            contactService.ShowContacts();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        IContactService contactService2 = new ContactService();
                        contactService2.ShowContacts();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Enter Id >>> ");
                        IContactService contactService3 = new ContactService();
                        contactService3.DeleteContactById(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Do you want see the result? Enter [yes/no] >>> ");
                        if (Console.ReadLine() == "yes")
                        {
                            Console.Clear();
                            contactService3.ShowContacts();
                        }
                        break;

                    case 4:
                        break;

                    case 5: 
                        again = false;
                        Console.Clear();
                        Console.WriteLine("Thanks, Bye!\n");
                        break;

                }
                if (myChoose != 5)
                {
                    Console.Write("\nDo you want to use other operations? >>> ");
                    if (Console.ReadLine() == "no")
                    {
                        again = false;
                        Console.Clear();
                        Console.WriteLine("Thanks, Bye!\n");
                    }
                }
            } while (again);

            void ShowMenu()
            {
                Console.WriteLine("\t-= Welcome to my project! =-");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Show All Contacts");
                Console.WriteLine("3. Delete Contact By Id");
                Console.WriteLine("4. Update Contact By Id");
                Console.WriteLine("5. Exit");
            }
        }
    }
}