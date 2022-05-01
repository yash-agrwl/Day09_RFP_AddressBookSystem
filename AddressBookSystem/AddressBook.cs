using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        private List<Person> _contactList = new();

        public void AddRecords(Person p)
        {
            _contactList.Add(p);
            Console.WriteLine("\nRecord successfully Added in Address Book");
        }

        public void DisplayRecords()
        {
            Console.WriteLine("\nThe Contact Details Available in Address Book are:\n");
            foreach (Person p in _contactList)
                Console.WriteLine(p.DisplayContact());
        }
    }
}
