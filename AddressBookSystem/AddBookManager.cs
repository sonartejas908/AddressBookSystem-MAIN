using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace AddressBookSystem
{
    public class WelcomeMessage
    {
        public void Welcome()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("       Welcome To Address Book");
            Console.WriteLine("=====================================");
        }

        public void DisplayMsg()
        {
            Console.WriteLine("\t---MAIN-WINDOW---\n\n  [Please Select]");
            Console.WriteLine(" -Press 1 to Add Contact");
            Console.WriteLine(" -Press 2 to List Contact");
            Console.WriteLine(" -Press 3 to Edit Contact");
            Console.WriteLine(" -Press 4 to Delete Contact");
            Console.WriteLine(" -Press 5 to Search Contact");
            Console.WriteLine(" -Press 6 to Sort Contact");
            Console.WriteLine(" -Press 7 to View List by State or City");
            Console.WriteLine(" -Press 8 to Count Contact by State or City");
            Console.WriteLine(" -Press 9 to Add Multiple Contact");
            Console.WriteLine(" -Press 10 to Add Address Book");
            Console.WriteLine(" -Press 11 to Display Address Book");
            Console.WriteLine(" -Press 12 to Sort by City,State or ZipCode");
            Console.WriteLine(" -Press 13 to Export Contact to Txt file");
            Console.WriteLine(" -Press 14 to Export Contact to CSV file");
            Console.WriteLine(" -Press 15 to Export Contact to Json file");
            Console.WriteLine(" -Press 16 to Exit");
            Console.WriteLine();
            Console.Write(" Enter choise :");
        }
    }


    public class AddBookManager
    {
        public List<Person> People = new List<Person>();
        public Dictionary<string, List<Person>> Mydict = new Dictionary<string, List<Person>>();

        public void AddPerson()
        {
            bool flag = false;
            while (flag != true)
            {
                Console.WriteLine("\t[Add Contact]");
                Person person = new Person();
                Console.Write("-Enter First Name :");
                string name = Console.ReadLine();

                if (People.Any(x => x.Fname.ToLower() == name.ToLower()))
                {
                    Console.WriteLine("{0} Already Exists..Try Another One.", name);
                }
                else
                {
                    flag = true;
                    person.Fname = name;
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
            }


        }
        private void PrintPerson(Person person)
        {
            Console.WriteLine("First Name :" + person.Fname);
            Console.WriteLine("Last Name :" + person.Lname);
            Console.WriteLine("Address :" + person.Address);
            Console.WriteLine("City :" + person.City);
            Console.WriteLine("State :" + person.State);
            Console.WriteLine("Zip Code :" + person.ZipCode);
            Console.WriteLine("Phone Number :" + person.PhonNumber);
            Console.WriteLine("Email :" + person.Email);
            Console.WriteLine("-------------------------------------");
        }
        public void ListPeople()
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
        public void Editperson()
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
        public void RemovePerson()
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
        public void AddMultipleContact()
        {
            Console.Write("Specify number of Contcts to be Created :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (num != 0)
            {
                AddPerson();
                num--;
            }
        }
        public void AddAddressBook()
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
        public void DisplayAddressBook()
        {
            Console.WriteLine("Here are current Address Book in System -");
            foreach (var dict in Mydict)
            {

                Console.WriteLine("-{0}", dict.Key);
                Console.WriteLine("Press any key to comtinue..");
                Console.ReadKey();
                Console.Clear();

            }
        }
        public void SearchContactByCityorState()
        {
            Console.Write("Please enter 1  for City 2 for State :");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
            {
                Console.Write("Enter City Name :");
                string city = Console.ReadLine();
                foreach (Person person in People.FindAll(e => e.City.ToLower() == city.ToLower()))
                {
                    PrintPerson(person);

                }

            }
            else
            {
                Console.Write("Enter State Name :");
                string state = Console.ReadLine();
                foreach (Person person in People.FindAll(e => e.State.ToLower() == state.ToLower()))
                {
                    PrintPerson(person);

                }

            }
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();

        }
        public void DictCityorState()
        {
            Console.Write("Please enter 1  for City 2 for State :");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
            {

                Console.Write("Please enter city Name :");
                string city = Console.ReadLine();
                List<Person> CityList = new List<Person>();
                foreach (Person person in People.FindAll(e => e.City.ToLower() == city.ToLower()))
                {
                    CityList.Add(person);
                }
                Mydict.Add(city, CityList);
                foreach (var element in Mydict[city])
                {
                    PrintPerson(element);
                }
                int cityCount = Mydict[city].Count();
                Console.WriteLine("Total :{0}", cityCount);

            }
            else
            {
                Console.Write("Please enter State Name :");
                string state = Console.ReadLine();
                List<Person> Statelist = new List<Person>();
                foreach (Person person in People.FindAll(e => e.State.ToLower() == state.ToLower()))
                {
                    Statelist.Add(person);
                }
                Mydict.Add(state, Statelist);

                foreach (var element in Mydict[state])
                {
                    PrintPerson(element);
                }
                int stateCount = Mydict[state].Count;
                Console.WriteLine("Total :{0}", stateCount);

            }
            Console.WriteLine("Press any key to Continue ..");
            Console.ReadKey();
            Console.Clear();
        }
        public void SortContactbyName()
        {
            foreach (var element in People.OrderBy(e => e.Fname).ToList())
            {
                if (People.Contains(element))
                {
                    PrintPerson(element);
                }
                else
                {
                    Console.WriteLine("No Contact present..");
                }
            }
            Console.WriteLine("Press any key to Continue ..");
            Console.ReadKey();
            Console.Clear();
        }
        public void SortbyCityStateZip()
        {
            Console.Write("\t[SORT]\n -Press 1 for City \n -Press 2 for State \n -Press 3 for ZipCode \n  Please Select :");
            int response = Convert.ToInt32(Console.ReadLine());
            switch (response)
            {
                case 1:
                    foreach (var element in People.OrderBy(e => e.City).ToList())
                    {
                        if (People.Contains(element))
                        {
                            PrintPerson(element);
                        }
                        else
                        {
                            Console.WriteLine("No Contact present..");
                        }
                    }
                    break;
                case 2:
                    foreach (var element in People.OrderBy(e => e.State).ToList())
                    {
                        if (People.Contains(element))
                        {
                            PrintPerson(element);
                        }
                        else
                        {
                            Console.WriteLine("No Contact present..");
                        }
                    }
                    break;
                case 3:
                    foreach (var element in People.OrderBy(e => e.ZipCode).ToList())
                    {
                        if (People.Contains(element))
                        {
                            PrintPerson(element);
                        }
                        else
                        {
                            Console.WriteLine("No Contact present..");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Choose valid Option...");
                    break;
            }
            Console.WriteLine("Press any key to Continue ..");
            Console.ReadKey();
            Console.Clear();
        }
        public void WriteUsingStreamWriter()
        {
            String path = @"C:\Users\User\source\repos\AddressBookSystemSub\AddressBookSystem-MAIN\AddressBookSystem\ContactList.txt";
            foreach (var element in People)
            {
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine("First Name :{0}\nLast Name :{1}\nAddress :{2}\nCity :{3}\nState :{4}\nZip Code :{5}\nPhone Number :{6}\nEmail :{7}", element.Fname, element.Lname, element.Address, element.City, element.State, element.ZipCode, element.PhonNumber, element.Email);
                    sr.Close();
                }

            }


        }
        public void WriteUsingCSVwriter()
        {
            String path = @"C:\Users\User\source\repos\AddressBookSystemSub\AddressBookSystem-MAIN\AddressBookSystem\ContactListCSV.csv";
          
                using StreamWriter sr = new StreamWriter(path);
                using (var csvExport = new CsvWriter(sr,CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(People);
                }

        }
        public void WriteUsingJsonWriter()
        {
            string path = @"C:\Users\User\source\repos\AddressBookSystemSub\AddressBookSystem-MAIN\AddressBookSystem\ContactList-Json.csv";
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, People);
            }
        }
    }
}

