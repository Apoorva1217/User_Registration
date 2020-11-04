using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using User_Registration;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace User_Registration_Test
{
    [TestClass]
    public class Test
    {
        private readonly Pattern patterns;
        private readonly object DataRow;

        public Test()
        {
            patterns = new Pattern();
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenStartsWithCapAndMinThreeChar_ShouldReturnTrue()
        {
            string expected = "Appu";
            string result = patterns.ValidateFirstName(expected);
            Assert.AreEqual(result,expected);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnTrue()
        {
            try
            {
                string result = patterns.ValidateFirstName("Ap");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenNotStartsWithCapAndMinThreeChar_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidateFirstName("appU");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenAllLettersAreCapitalAndMinThreeChar_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidateFirstName("APPU");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenLastName_WhenStartsWithCapAndMinThreeChar_ShouldReturnTrue()
        {
            string expected = "Rasal";
            string result = patterns.ValidateLastName(expected);
            Assert.AreEqual(result,expected);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenlastName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidateLastName("Ra");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenLastName_WhenNotStartsWithCapAndMinThreeChar_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidateLastName("raSal");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenLastName_WhenAllLettersAreCapitalAndMinThreeChar_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidateLastName("RASAL");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate email
        /// </summary>
        [TestMethod]
        public void GivenEmailId_WhenProper_ShouldReturnTrue()
        {
            string expected = "Appu12@gmail.com";
            string result = patterns.ValidateEmail(expected);
            Assert.AreEqual(result,expected);
        }

        /// <summary>
        /// Test Method to validate email
        /// </summary>
        [TestMethod]
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidateEmail("appu@gmail");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid mailID", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [TestMethod]
        public void GivenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            string expected = "91 9876543212";
            string result = patterns.ValidateMobileNumber("91 9876543212");
            Assert.AreEqual(result,expected);
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [TestMethod]
        public void GivenMobileNumber_WhenLessThanTenDigits_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidateMobileNumber("89 2435462");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid mobileNumber", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [TestMethod]
        public void GivenMobileNumber_WhenNoSpaceAfterCountryCode_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidateMobileNumber("917654378967");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid mobileNumber", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenWithMinimumEightChracters_ShouldReturnTrue()
        {
            string expected = "sge#EEhw4";
            string result = patterns.ValidatePassword("sge#EEhw4");
            Assert.AreEqual(result,expected);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenLessThanEightChracters_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidatePassword("ste5SD");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid password", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenNotContainUpperCaseChar_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidatePassword("234%56");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid password", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenNotContainNumericNumber_ShouldReturnFalse()
        {
            try
            {
                string result = patterns.ValidatePassword("ase!df");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid password", e.Message);
            }
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", true)]
        [DataRow("abc-100@yahoo.com", true)]
        [DataRow("abc.100@yahoo.com",true)]
        [DataRow("abc111@abc.com",true)]
        [DataRow("abc-100@abc.net",true)]
        [DataRow("abc.100@abc.com.au",true)]
        [DataRow("abc@1.com",true)]
        [DataRow("abc@gmail.com.com",true)]
        [DataRow("abc+100@gmail.com",true)]
        public void GivenEmails_WhenChecked_ShouldReturnTrue(string email, string expected)
        {
            string result = patterns.ValidateEmail(expected);
            Assert.AreEqual(result,expected);
        }

        [TestMethod]
        [DataRow("abc")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.2a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void GivenEmails_WhenChecked_ShouldReturnFalse(string email)
        {
            try
            {
                string result = patterns.ValidateEmail(email);
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid mailID", e.Message);
            }
        }
    }
}