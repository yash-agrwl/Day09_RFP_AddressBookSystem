using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To Computation of Address Book System Program\n");

            Person person = new();
            person.InputContact();
            Console.WriteLine("\nThe Entered Contact Details are:\n" + person.DisplayContact());
        }
    }
}
