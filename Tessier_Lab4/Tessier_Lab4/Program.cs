using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tessier_Lab4
{
    class Program
    {
        struct Person
        {
            public string FirstName;
            public string LastName;
            public string MiddleName;
            public string Street1;
            public string Street2;
            public string City;
            public string State;
            public int Zip;
            public string Phone;
            public string Email;
        }

        static void Main(string[] args)
        {
            Person temp = new Person();

            //For entering in a first name
            Console.Write("Enter a first name: ");
            temp.FirstName = Console.ReadLine();

            //For entering in the middle name
            Console.Write("Enter a middle name: ");
            temp.MiddleName = Console.ReadLine();

            //For entering in the last name of the person
            Console.Write("Enter a last name: ");
            temp.LastName = Console.ReadLine();

            //For entering in the first portion of the person's street (excluding apartment #s)
            Console.Write("Enter the street address: ");
            temp.Street1 = Console.ReadLine();

            //For entering in the person's apartment #
            Console.Write("Enter an apartment number: ");
            temp.Street2 = Console.ReadLine();

            //For entering in the person's city
            Console.Write("Enter a city name: ");
            temp.City = Console.ReadLine();

            //For entering in the person's state
            Console.Write("Enter a state name: ");
            temp.State = Console.ReadLine();

            //For entering in the person's zipcode
            Console.Write("Enter a zip code: ");
            temp.Zip = Int32.Parse(Console.ReadLine());

            //For entering in the person's phone #
            Console.Write("Enter a phone number: ");
            temp.Phone = Console.ReadLine();

            //For entering in the person's email
            Console.Write("Enter an email: ");
            temp.Email = Console.ReadLine();

            Console.Write("The values for this person are as follows: ");
            Console.Write($"\nFirst Name: {temp.FirstName}");
            Console.Write($"\nMiddle Name: {temp.MiddleName}");
            Console.Write($"\nLast Name: {temp.LastName}");
            Console.Write($"\nAddress: {temp.Street1}");
            Console.Write($"\nApartment No.: {temp.Street2}");
            Console.Write($"\nCity: {temp.City}");
            Console.Write($"\nState: {temp.State}");
            Console.Write($"\nZip Code: {temp.Zip}");
            Console.Write($"\nPhone Number: {temp.Phone}");
            Console.Write($"\nEmail: {temp.Email}");
        }
    }
}
