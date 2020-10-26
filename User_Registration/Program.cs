using NUnit.Framework.Internal;
using System;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");
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
        }
    }
}
