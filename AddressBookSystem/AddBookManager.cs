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
            Console.WriteLine(" -Press 4 to Delete Contact");
            Console.WriteLine(" -Press 5 to Add Multiple Contact");
            Console.WriteLine(" -Press 6 to Add Address Book");
            Console.WriteLine(" -Press 7 to Display Address Book");
            Console.WriteLine(" -Press 8 to Exit");
            Console.WriteLine();
            Console.Write(" Enter choise :");
        }
    }


    public class AddBookManager
    {
        public static List<Person> People = new List<Person>();
        public static Dictionary<string, List<Person>> Mydict = new Dictionary<string, List<Person>>();

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
        public static void RemovePerson()
        {
            Console.WriteLine("\t[Remove Contact]");
            Console.WriteLine("Enter the First name of person you wants to remove");
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
                PrintPerson(person);
                Console.WriteLine("Are you sure you want to remove this person? (Y/N) ");

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    People.Remove(person);
                    Console.WriteLine("Person removed. Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
        public static void AddMultipleContact()
        {
            Console.Write("Specify number of Contcts to be Created :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while(num != 0)
            {
                AddPerson();
                num--;
            }
        }
        public static void AddAddressBook()
        {
            bool flag = false;
            while (flag != true)
            {
                Console.Write("Enter the Name of Address Book :");
                string uniqname = Console.ReadLine();

                if (Mydict.ContainsKey(uniqname))
                {
                    Console.WriteLine("{0} Address Book Already Exists. Try Different one..", uniqname);
                    Console.WriteLine("Press any key to Continue ..");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Mydict.Add(uniqname, People);
                    Console.WriteLine("Address Book Saved.");
                    flag = true;
                }
            }
               
        }
        public static void DisplayAddressBook()
        {
            Console.WriteLine("Here are current Address Book in System -");
            foreach(var dict in Mydict)
            {
                
                Console.WriteLine("-{0}",dict.Key);
                Console.WriteLine("Press any key to comtinue..");
                Console.ReadKey();
                Console.Clear();
                
            }
        }
    }
}

