using System;

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
            Pattern pattern = new Pattern();
            Console.WriteLine("Welcome to User Registration Program!");
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateFirstName(firstName));
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateLastName(lastName));
            Console.WriteLine("Enter Email ID:");
            string emailID = Console.ReadLine();
            Console.WriteLine(pattern.ValidateemailID(emailID));
            Console.WriteLine("Enter Mobile Number:");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(pattern.ValidateMobileNumber(mobileNumber));
        }
    }
}
