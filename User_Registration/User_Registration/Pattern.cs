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
        public static string namePattern = "^[A-Z][a-z]{2,}$";

        /// <summary>
        /// Regex pattern for Email ID
        /// </summary>
        public static string mailIDPattern = "^[0-9a-zA-Z]+([+_.-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{2,3}){1,2}$";

        /// <summary>
        /// Regex pattern for Mobile Number
        /// </summary>
        public static string mobileNumberPattern = "^[1-9]{2}[ ][0-9]{10}";

        /// <summary>
        /// Regex pattern for Password
        /// </summary>
        public static string passwordPattern = "(?=.*[A-Z]{1,})(?=.*[a-z]{1,})(?=.*[0-9]{1,})(?=.*[@#$%+!]{1}).{8,}";

        /// <summary>
        /// Validate First Name with Lambda Expression
        /// </summary>
        public Func<string, string> ValidateFirstName = x => Regex.IsMatch(x, namePattern) ? "Valid First Name" :
           throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRST_NAME, "Invalid First Name");

        /// <summary>
        /// Validate Last Name with Lambda Expression
        /// </summary>
        public Func<string, string> ValidateLastName = x => Regex.IsMatch(x, namePattern) ? "Valid Last Name" :
           throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LAST_NAME, "Invalid Last Name");


        /// <summary>
        /// Validate Email ID with Lambda Expression
        /// </summary>
        public Func<string, string> ValidateEmail = x => Regex.IsMatch(x, mailIDPattern) ? "Valid mailID" :
           throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid mailID");

        /// <summary>
        /// Validate Mobile Number with Lambda Expression
        /// </summary>
        public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, mobileNumberPattern) ? "Valid mobileNumber" :
           throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid mobileNumber");

        /// <summary>
        /// Validate Password with Lambda Expression
        /// </summary>
        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, passwordPattern) ? "Valid password" :
           throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid password");
    }
}