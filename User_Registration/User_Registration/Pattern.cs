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
            try
            {
                if (Regex.IsMatch(firstName, this.namePattern))
                {
                    Console.WriteLine("Valid First Name");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid First Name");
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRST_NAME, "Invalid First Name");
            }
        }

        /// <summary>
        /// Validate Last Name with Regex Pattern
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool ValidateLastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, this.namePattern))
                {
                    Console.WriteLine("Valid Last Name");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name");
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LAST_NAME, "Invalid Last Name");
            }
        }

        /// <summary>
        /// Validate Mail ID with Regex Pattern
        /// </summary>
        /// <param name="mailID"></param>
        /// <returns></returns>
        public bool ValidateEmail(string mailID)
        {
            try
            {
                if (Regex.IsMatch(mailID, this.mailIDPattern))
                {
                    Console.WriteLine("Valid mailID");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid mailID");
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid mailID");
            }
        }

        /// <summary>
        /// Validate Mobile Number with Regex Pattern
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string mobileNumber)
        {
            try
            {
                if (Regex.IsMatch(mobileNumber, this.mobileNumberPattern))
                {
                    Console.WriteLine("Valid mobileNumber");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid mobileNumber");
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobileNumber");
            }
        }

        /// <summary>
        /// Validate Password with Regex Pattern
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, this.passwordPattern))
                {
                    Console.WriteLine("Valid password");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid password");
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid password");
            }
        }
    }
}
