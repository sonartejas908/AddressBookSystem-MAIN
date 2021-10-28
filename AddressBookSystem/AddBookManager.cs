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
            Console.WriteLine(" -Press 2 to Exit");
            Console.WriteLine();
            Console.Write(" Enter choise :");
        }
    }


    public class AddBookManager
    {

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


            Console.WriteLine("Contact saved successfully....");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();


        }

    }
}

