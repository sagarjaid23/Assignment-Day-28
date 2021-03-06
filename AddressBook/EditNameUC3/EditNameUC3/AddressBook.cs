using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditNameUC3
{
    internal class AddressBook
    {
            public static List<PersonDetails> addressBook = new List<PersonDetails>();

            public static void AddContact()
            {
                Console.WriteLine(" You have to enter your details here. \n");
                int contactsNum = 1;
                while (contactsNum > 0)
                {
                    PersonDetails person = new PersonDetails();

                    Console.Write(" Enter your First name : ");
                    person.Firstname = Console.ReadLine();
                    Console.Write(" Enter your Last name : ");
                    person.LastName = Console.ReadLine();
                    Console.Write(" Enter your Address : ");
                    person.Address = Console.ReadLine();
                    Console.Write(" Enter your City : ");
                    person.City = Console.ReadLine();
                    Console.Write(" Enter your State : ");
                    person.State = Console.ReadLine();
                    Console.Write(" Enter your Zip code : ");
                    person.ZipCode = Console.ReadLine();
                    Console.Write(" Enter your Phone number : ");
                    person.PhoneNumber = Console.ReadLine();
                    Console.Write(" Enter your Email ID : ");
                    person.Email = Console.ReadLine();

                    addressBook.Add(person);
                    Console.WriteLine("\n {0}'s contact succesfully added", person.Firstname);
                    contactsNum--;
                }
            }
            public static void Display()
            {
                if (addressBook.Count > 0)
                {
                    Console.Write("\n Enter the name of the person to get all the contact details : ");
                    string nameKey = Console.ReadLine();
                    foreach (PersonDetails contact in addressBook)
                    {
                        if (nameKey.ToLower() == contact.Firstname.ToLower())
                        {
                            Console.WriteLine(" First name-->{0}", contact.Firstname);
                            Console.WriteLine(" Last name-->{0}", contact.LastName);
                            Console.WriteLine(" Address-->{0}", contact.Address);
                            Console.WriteLine(" City-->{0}", contact.City);
                            Console.WriteLine(" State-->{0}", contact.State);
                            Console.WriteLine(" Zip code-->{0}", contact.ZipCode);
                            Console.WriteLine(" Phone number-->{0}", contact.PhoneNumber);
                            Console.WriteLine(" E-Mail ID-->{0}", contact.Email);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n Contact of the person {0} does not exist", nameKey);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Your address book is empty");
                }
            }

            public static void Edit()
            {
                Console.Write("\n Enter the first name of the person whom you want to edit the details : ");
                string editKey = Console.ReadLine();
                if (addressBook.Count > 0)
                {
                    foreach (PersonDetails persons in addressBook)
                    {
                        if (editKey.ToLower() == persons.Firstname.ToLower())
                        {
                            Console.WriteLine("\n Enter the key number for editing the details." +
                                "\n1.First Name " +
                                "\n2.Last Name " +
                                "\n3.Address " +
                                "\n4.City " +
                                "\n5.State " +
                                "\n6.Zipcode " +
                                "\n7.Phone Number " +
                                "\n8.Email ID");
                            Console.Write(" Enter your option : ");
                            int key = Convert.ToInt32(Console.ReadLine());
                            switch (key)
                            {
                                case 1:
                                    Console.Write("Enter the new First Name : ");
                                    persons.Firstname = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the new Last name");
                                    persons.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write(" Enter the New Address : ");
                                    persons.Address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Write(" Enter the New City : ");
                                    persons.City = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.Write(" Enter the New State : ");
                                    persons.State = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.Write("Enter the New Zip Code : ");
                                    persons.ZipCode = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.Write(" Enter the New Phone Number : ");
                                    persons.PhoneNumber = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.Write(" Enter the New EMail-ID : ");
                                    persons.Email = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine(" Please enter a valid input");
                                    Edit();
                                    break;

                            }
                            Console.WriteLine(" {0}'s contact has been successfully added", editKey);
                            break;
                        }
                    }
                    //Console.WriteLine(" Contact of the person {0} does not exist", editKey);
                }
                else
                {
                    Console.WriteLine(" Your address book is empty");
                }
            }
        }
    }

