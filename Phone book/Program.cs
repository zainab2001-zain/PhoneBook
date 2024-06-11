using System;
namespace Phone_book
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello from the console Phone Book App");
            Console.WriteLine("Select Operation: ");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display Contact By Number");
            Console.WriteLine("3 View all Contacts ");
            Console.WriteLine("4 Search for contact in a given name");
            Console.WriteLine("Press x to exit the program");
            var user_Input = Console.ReadLine();
            var phone_Book = new PhoneBook();

            while(true)
            {
                switch (user_Input)
                {
                    case "1":
                        Console.WriteLine("Contact Name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number: ");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phone_Book.AddContact(newContact);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;

                }
            }
           
        }
    }
}

