using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Pattern
    {
        /// <summary>
        /// Validate First Name
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public bool ValidateFirstName(string firstName)
        {
            if (!Regex.Match(firstName, "^[A-Z][a-z]{2,}$").Success)
            {
                Console.WriteLine("Invalid First Name");
                return false;
            }
            else
            {
                Console.WriteLine("Valid First Name");
                return true;
            }
        }

        /// <summary>
        /// Validate Last Name
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool ValidateLastName(string lastName)
        {
            if (!Regex.Match(lastName, "^[A-Z][a-z]{2,}$").Success)
            {
                Console.WriteLine("Invalid Last Name");
                return false;
            }
            else
            {
                Console.WriteLine("Valid Last Name");
                return true;
            }
        }
    }
}
