using NUnit.Framework;
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

        /// <summary>
        /// Validate Email ID
        /// </summary>
        /// <param name="emailID"></param>
        /// <returns></returns>
        public bool ValidateemailID(string emailID)
        {
            if (!Regex.Match(emailID, "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+[.]+([a-zA-Z]{2,4})+[.]*([a-zA-Z]{2})*$").Success)
            {
                Console.WriteLine("Invalid emailID");
                return false;
            }
            else
            {
                Console.WriteLine("Valid emailID");
                return true;
            }
        }

        /// <summary>
        /// Validate Mobile Number
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string mobileNumber)
        {
            if (!Regex.Match(mobileNumber, "^[0-9]{2} [0-9]{10}").Success)
            {
                Console.WriteLine("Invalid mobileNumber");
                return false;
            }
            else
            {
                Console.WriteLine("Valid mobileNumber");
                return true;
            }
        }

        /// <summary>
        /// Validate Password
        /// Rule 4-> has exactly one special character
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            if (!Regex.Match(password, "(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*-+]{1}).{8,}").Success)
            {
                Console.WriteLine("Invalid password");
                return false;
            }
            else
            {
                Console.WriteLine("Valid password");
                return true;
            }
        }

        /// <summary>
        /// Validate Given Email samples
        /// </summary>
        public void GivenEmails_WhenChecked_ShouldReturnExpectedResult()
        {
            
            Assert.IsTrue(ValidateemailID("abc@yahoo.com"));
            Assert.IsTrue(ValidateemailID("abc-100@yahoo.com"));
            Assert.IsTrue(ValidateemailID("abc.100@yahoo.com"));
            Assert.IsTrue(ValidateemailID("abc111@abc.com"));
            Assert.IsTrue(ValidateemailID("abc-100@abc.net"));
            Assert.IsTrue(ValidateemailID("abc.100@abc.com.au"));
            Assert.IsTrue(ValidateemailID("abc@1.com"));
            Assert.IsTrue(ValidateemailID("abc@gmail.com.com"));
            Assert.IsTrue(ValidateemailID("abc+100@gmail.com"));
            Assert.IsFalse(ValidateemailID("abc"));
            Assert.IsFalse(ValidateemailID("abc123@gmail.a"));
            Assert.IsFalse(ValidateemailID("abc123@.com"));
            Assert.IsFalse(ValidateemailID("abc123@.com.com"));
            Assert.IsFalse(ValidateemailID(".abc@abc.com"));
            Assert.IsFalse(ValidateemailID("abc()*@gmail.com"));
            Assert.IsFalse(ValidateemailID("abc@%*.com"));
            Assert.IsFalse(ValidateemailID("abc..2002@gmail.com"));
            Assert.IsFalse(ValidateemailID("abc.@gmail.com"));
            Assert.IsFalse(ValidateemailID("abc@abc@gmail.com"));
            Assert.IsFalse(ValidateemailID("abc@gmail.com.2a"));
            Assert.IsFalse(ValidateemailID("abc@gmail.com.aa.au"));
        }
    }
}
