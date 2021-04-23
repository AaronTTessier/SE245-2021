using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tessier_Lab4
{
    class Program
    {
        public class Person
        {
            private string firstName;
            private string lastName;
            private string middleName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private int zipCode;
            private string phone;
            private string email;

            public string FirstName
            {
                get
                {
                    return firstName;
                }

                set
                {
                    firstName = value;
                }
            }

            public string MiddleName
            {
                get
                {
                    return middleName;
                }

                set
                {
                    middleName = value;
                }
            }

            public string LastName
            {
                get
                {
                    return lastName;
                }

                set
                {
                    lastName = value;
                }
            }

            public string Street1
            {
                get
                {
                    return street1;
                }

                set
                {
                    street1 = value;
                }
            }

            public string Street2
            {
                get
                {
                    return street2;
                }

                set
                {
                    street2 = value;
                }
            }
            public string City
            {
                get
                {
                    return city;
                }

                set
                {
                    city = value;
                }
            }

            public string State
            {
                get
                {
                    return state;
                }

                set
                {
                    state = value;
                }
            }

            public int ZipCode
            {
                get
                {
                    return zipCode;
                }

                set
                {
                    zipCode = value;
                }
            }

            public string Phone
            {
                get
                {
                    return phone;
                }

                set
                {
                    phone = value;
                }
            }
            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    email = value;
                }
            }
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
            temp.ZipCode = Int32.Parse(Console.ReadLine());

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
            Console.Write($"\nZip Code: {temp.ZipCode}");
            Console.Write($"\nPhone Number: {temp.Phone}");
            Console.Write($"\nEmail: {temp.Email}");
        }
    }
}
