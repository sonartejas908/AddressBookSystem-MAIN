﻿using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage.Welcome();
            bool isExit = false;
            while (isExit != true)
            {
                WelcomeMessage.DisplayMsg();
                int response = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (response)
                    {
                        case 1:
                            AddBookManager.AddPerson();
                            Console.WriteLine();
                            break;
                        case 2:
                            AddBookManager.ListPeople();
                            break;
                        case 3:
                            AddBookManager.Editperson();
                            break;
                        case 4:
                            AddBookManager.RemovePerson();
                            break;
                        case 5:
                            AddBookManager.SearchContactByCityorState();
                            break;
                        case 6:
                            AddBookManager.DictCityorState();
                            break;
                        case 7:
                            AddBookManager.AddMultipleContact();
                            break;
                        case 8:
                        AddBookManager.AddAddressBook();
                            break;
                        case 9:
                        AddBookManager.DisplayAddressBook();
                            break;
                        case 10:
                            isExit = true;
                            break;
                        default:
                        Console.WriteLine("Please enter valid Input");
                            break;
                    }

            }

        }
    }
}
            
           
     
