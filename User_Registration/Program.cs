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
                Console.WriteLine("Invalid First Name");
            }
            else
            {
                Console.WriteLine("Valid First Name");
            }

            //Validate Last Name using Regex Pattern
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            if (!Regex.Match(lastName, "^[A-Z][a-z]{2,}$" ).Success)
            {
                Console.WriteLine("Invalid Last Name");
            }
            else
            {
                Console.WriteLine("Valid Last Name");
            }
        }
    }
}
