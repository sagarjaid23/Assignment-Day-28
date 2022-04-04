
using System;

namespace EditNameUC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program \n");

            AddressBook.Display();
            AddressBook.AddContact();
            AddressBook.Edit();
            AddressBook.Display();
        }
    }
}
