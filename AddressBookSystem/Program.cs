using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage welcomeMessage = new WelcomeMessage();
            AddBookManager addBookManager = new AddBookManager();
            welcomeMessage.Welcome();
            bool isExit = false;
            while (isExit != true)
            {
                welcomeMessage.DisplayMsg();
                int response = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (response)
                    {
                        case 1:
                        addBookManager.AddPerson();
                            break;
                        case 2:
                           addBookManager.ListPeople();
                            break;
                        case 3:
                           addBookManager.Editperson();
                            break;
                        case 4:
                           addBookManager.RemovePerson();
                            break;
                        case 5:
                           addBookManager.SearchContactByCityorState();
                            break;
                        case 6:
                           addBookManager.SortContactbyName();
                            break;
                        case 7:
                           addBookManager.DictCityorState();
                            break;
                        case 8:
                           addBookManager.DictCityorState();
                            break;
                        case 9:
                            addBookManager.AddMultipleContact();
                            break;
                        case 10:
                       addBookManager.AddAddressBook();
                            break;
                        case 11:
                        addBookManager.DisplayAddressBook();
                            break;
                        case 12:
                        addBookManager.SortbyCityStateZip();
                            break;
                        case 13:
                            addBookManager.WriteUsingStreamWriter();
                            break;
                        case 14:
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
            
           
     
