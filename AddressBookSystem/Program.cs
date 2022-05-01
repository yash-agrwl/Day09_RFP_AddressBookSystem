using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To Computation of Address Book System Program\n");

            AddressBook book1 = new();

            Person person = new();
            person.InputContact();

            book1.AddRecords(person);
            book1.DisplayRecords();
        }
    }
}
