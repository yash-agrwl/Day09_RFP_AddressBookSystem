﻿using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To Computation of Address Book System Program");

            AddressBook book1 = new();
            Person person = new();

            string input;
            do
            {
                UserMenu();
                input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                        Console.WriteLine("\nEnter Details to Add New Contact-");
                        person.InputContact();
                        book1.AddRecords(person);
                        break;
                    case "E":
                        Console.WriteLine("\nEnter Name of the person to edit-");
                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();
                        book1.EditRecords(firstName, lastName);
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
            Console.WriteLine("Enter 'E' to edit existing contact.");
            Console.WriteLine("Enter 'P' to display all address book contacts");
            Console.WriteLine("Enter 'X' to exit.");
            Console.Write("Input: ");
        }
    }
}
