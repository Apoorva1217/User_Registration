using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Pattern
    {
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
    }
}
