using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To Computation of Address Book System Program");

            AddressBook book1 = new();

            string input;
            do
            {
                UserMenu();
                input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                        string option;
                        do
                        {
                            Console.WriteLine("\nEnter Details to Add New Contact-");
                            book1.AddRecords();

                            loop:
                                Console.WriteLine("\nPress 'a' to add new record.");
                                Console.WriteLine("Press 'r' to return to the User Menu");
                                Console.Write("Enter Choice: ");
                                option = Console.ReadLine();
                                if (option != "r" && option != "a")
                                {
                                    Console.WriteLine("\nInvalid Choice Entered.");
                                    goto loop;
                                }
                        }
                        while (option != "r");
                        break;
                    case "E":
                        Console.WriteLine("\nEnter Name of the person to edit-");
                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();
                        book1.EditRecords(firstName, lastName);
                        break;
                    case "D":
                        Console.WriteLine("\nEnter Name of the person to delete-");
                        Console.Write("First Name: ");
                        firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        lastName = Console.ReadLine();
                        book1.DeleteRecords(firstName, lastName);
                        break;
                    case "P":
                        book1.DisplayRecords();
                        break;
                    case "X":
                        Console.WriteLine("\nProgram Exited Successfully.");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Input.");
                        break;
                }
            }
            while (input != "X");

        }

        public static void UserMenu()
        {
            Console.WriteLine("\n--------User Menu--------");
            Console.WriteLine("Enter 'A' to add new contact.");
            Console.WriteLine("Enter 'D' to delete an existing contact.");
            Console.WriteLine("Enter 'E' to edit an existing contact.");
            Console.WriteLine("Enter 'P' to display all address book contacts");
            Console.WriteLine("Enter 'X' to exit.");
            Console.Write("Input: ");
        }
    }
}
