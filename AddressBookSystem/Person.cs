using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string ZipCode;
        public long PhoneNumber;
        public string EmailId;

        public void InputContact()
        {
            Console.Write("Enter First-Name: ");
            this.FirstName = Console.ReadLine();
            Console.Write("Enter Last-Name: ");
            this.LastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            this.Address = Console.ReadLine();
            Console.Write("Enter City: ");
            this.City = Console.ReadLine();
            Console.Write("Enter State: ");
            this.State = Console.ReadLine();
            Console.Write("Enter Zip-Code: ");
            this.ZipCode = Console.ReadLine();
            Console.Write("Enter ContactNumber: ");
            this.PhoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter Email-Id: ");
            this.EmailId = Console.ReadLine();
        }

        public string DisplayContact()
        {
            return "First Name: " + FirstName + "\nLast Name:  " + LastName + "\nAddress: " + Address + "\nCity: " + City
                + "\nState: " + State + "\nZip-Code: " + ZipCode + "\nPhone: " + PhoneNumber + "\nEmail-Id: " + EmailId + "\n";
        }
    }
}
