using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookSystem
{
    public class WelcomeMessage
    {
        public static void Welcome()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("       Welcome To Address Book");
            Console.WriteLine("=====================================");
        }

        public static void DisplayMsg()
        {
            Console.WriteLine("\t---MAIN-WINDOW---\n\n  [Please Select]");
            Console.WriteLine(" -Press 1 to Add Contact");
            Console.WriteLine(" -Press 2 to List Contact");
            Console.WriteLine(" -Press 3 to Edit Contact");
            Console.WriteLine(" -Press 4 to Exit");
            Console.WriteLine();
            Console.Write(" Enter choise :");
        }
    }


    public class AddBookManager
    {
        public static List<Person> People = new List<Person>();

        public static void AddPerson()
        {
            Console.WriteLine("\t[Add Contact]");
            Person person = new Person();
            Console.Write("-Enter First Name :");
            person.Fname = Console.ReadLine();
            Console.Write("-Enter Last Name :");
            person.Lname = Console.ReadLine();
            Console.Write("-Enter Address :");
            person.Address = Console.ReadLine();
            Console.Write("-Enter City :");
            person.City = Console.ReadLine();
            Console.Write("-Enter State :");
            person.State = Console.ReadLine();
            Console.Write("-Enter ZipCode :");
            person.ZipCode = Console.ReadLine();
            Console.Write("-Enter Phone Number :");
            person.PhonNumber = Console.ReadLine();
            Console.Write("-Enter Email :");
            person.Email = Console.ReadLine();

            People.Add(person);
            Console.WriteLine("Contact saved successfully....");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();


        }
        private static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name :" + person.Fname);
            Console.WriteLine("Last Name :" + person.Lname);
            Console.WriteLine("Address :" + person.Address);
            Console.WriteLine("City :" + person.City);
            Console.WriteLine("State :" + person.State);
            Console.WriteLine("Zip Code :" + person.ZipCode);
            Console.WriteLine("Phone Number :" + person.PhonNumber);
            Console.WriteLine("Email :" + person.Email);
        }
        public static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Address Book is empty. Press any key to continue ");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            Console.WriteLine("Here are current people in your address book:\n");
            foreach (var person in People)
            {
                PrintPerson(person);

                Console.WriteLine("=================================");
            }
            Console.WriteLine("\n Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

        }
        public static void Editperson()
        {
            Console.WriteLine("\t[Edit Contact]");
            Console.WriteLine("Enter the First name of person you wants to Edit");
            string firstName = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.Fname.ToLower() == firstName.ToLower());

            if (person == null)
            {
                Console.WriteLine("Person could not be found. press any key to continue");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            else
            {
                Console.WriteLine("Contact Found");
                Console.WriteLine("-------------------------------------");
                PrintPerson(person);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Press 1 to change First Name");
                Console.WriteLine("Press 2 to change Last Name");
                Console.WriteLine("Press 3 to change Address");
                Console.WriteLine("Press 4 to change City");
                Console.WriteLine("Press 5 to change State");
                Console.WriteLine("Press 6 to change ZipCode");
                Console.WriteLine("Press 7 to change Phone Number");
                Console.WriteLine("Press 8 to change Email");
                Console.Write("Enter Choise :");
                int response = int.Parse(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        Console.Write("Please Enter new Name :");
                        person.Fname = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Please Enter new Last Name :");
                        person.Lname = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Please Enter New Address :");
                        person.Address = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Please Enter new City :");
                        person.City = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Please Enter new State :");
                        person.State = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Please Enter new Zip Code :");
                        person.ZipCode = Console.ReadLine();
                        break;
                    case 7:
                        Console.Write("Please Enter new Phone Number :");
                        person.PhonNumber = Console.ReadLine();
                        break;
                    case 8:
                        Console.Write("Please Enter new Email :");
                        person.Email = Console.ReadLine();
                        break;
                }
                Console.WriteLine("Contact edited Successfully.........");
                Console.WriteLine("Press any Key to continue.");
                Console.ReadKey();
                Console.Clear();

            }

        }
    }
}

