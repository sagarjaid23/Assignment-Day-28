using System;

namespace NewContatctUC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program \n");

            // UC1 : Ability to create a Contacts in Address Book with first and last names, address,
            // city, state, zip, phone number and email...
            AddressBook.Display();
            AddressBook.AddContact();
        }
    }
}
