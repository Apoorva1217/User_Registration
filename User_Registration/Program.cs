using NUnit.Framework.Internal;
using System;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        /// <summary>
        /// User Registration Program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");

            //Validate First Name using Regex Pattern
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            if(!Regex.Match(firstName, "^[A-Z][a-z]{2,}$" ).Success)
            {
                Console.WriteLine("Invalid First Name \n");
            }
            else
            {
                Console.WriteLine("Valid First Name \n");
            }

            //Validate Last Name using Regex Pattern
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            if (!Regex.Match(lastName, "^[A-Z][a-z]{2,}$" ).Success)
            {
                Console.WriteLine("Invalid Last Name \n");
            }
            else
            {
                Console.WriteLine("Valid Last Name \n");
            }

            //Validate Email ID using Regex Pattern
            Console.WriteLine("Enter Email ID:");
            string emailID = Console.ReadLine();
            if (!Regex.Match(emailID, "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+[.]+([a-zA-Z]{2,4})+[.]*([a-zA-Z]{2})*$" ).Success)
            {
                Console.WriteLine("Invalid Email ID \n");
            }
            else
            {
                Console.WriteLine("Valid Email ID \n");
            }

            //Validate Mobile Number using Regex Pattern
            Console.WriteLine("Enter Mobile Number:");
            string mobileNumber = Console.ReadLine();
            if (!Regex.Match(mobileNumber, "^[0-9]{2} [0-9]{10}" ).Success)
            {
                Console.WriteLine("Invalid Mobile Number \n");
            }
            else
            {
                Console.WriteLine("Valid Mobile Number \n");
            }

            //Validate Password using Regex Pattern
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            //Rule 3-> should have atleast one numeric number
            if (!Regex.Match(password, "^(?=.*[A-Z].*)(?=.*[0-9].*)[A-Za-z0-9]{8,}" ).Success)
            {
                Console.WriteLine("Invalid Password \n");
            }
            else
            {
                Console.WriteLine("Valid Password \n");
            }
        }
    }
}
