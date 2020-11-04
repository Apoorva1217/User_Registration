using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Pattern
    {
        /// <summary>
        /// Regex pattern for First Name
        /// </summary>
        public readonly string namePattern = "^[A-Z][a-z]{2,}$";

        /// <summary>
        /// Regex pattern for Email ID
        /// </summary>
        public readonly string mailIDPattern = "^[0-9a-zA-Z]+([+_.-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{2,3}){1,2}$";

        /// <summary>
        /// Regex pattern for Mobile Number
        /// </summary>
        public readonly string mobileNumberPattern = "^[1-9]{2}[ ][0-9]{10}";

        /// <summary>
        /// Regex pattern for Password
        /// </summary>
        public readonly string passwordPattern = "(?=.*[A-Z]{1,})(?=.*[a-z]{1,})(?=.*[0-9]{1,})(?=.*[@#$%+!]{1}).{8,}";

        /// <summary>
        /// Validate First Name with Regex Pattern
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, this.namePattern);
        }

        /// <summary>
        /// Validate Last Name with Regex Pattern
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, this.namePattern);
        }

        /// <summary>
        /// Validate Mail ID with Regex Pattern
        /// </summary>
        /// <param name="mailID"></param>
        /// <returns></returns>
        public bool ValidateEmail(string mailID)
        {
            return Regex.IsMatch(mailID, this.mailIDPattern);
        }

        /// <summary>
        /// Validate Mobile Number with Regex Pattern
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, this.mobileNumberPattern);
        }

        /// <summary>
        /// Validate Password with Regex Pattern
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, this.passwordPattern);
        }
    }
}