using Effort.Internal.TypeGeneration;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using User_Registration;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace User_Registration_Tests
{
    [TestClass]
    public class Test
    {
        private readonly Pattern patterns;

        public Test()
        {
            patterns = new User_Registration.Pattern();
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenStartsWithCapAndMinThreeChar_ShouldReturnTrue()
        {

            bool result = patterns.ValidateFirstName("Appu");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnTrue()
        {
            try
            {
                bool result = patterns.ValidateFirstName("Ap");
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
                bool result = patterns.ValidateFirstName("appU");
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
                bool result = patterns.ValidateFirstName("APPU");
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

            bool result = patterns.ValidateLastName("Rasal");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenlastName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnFalse()
        {
            try
            {
                bool result = patterns.ValidateLastName("Ra");
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
                bool result = patterns.ValidateLastName("raSal");
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
                bool result = patterns.ValidateLastName("RASAL");
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

            bool result = patterns.ValidateEmail("Appu12@gmail.com");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate email
        /// </summary>
        [TestMethod]
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse()
        {
            try
            {
                bool result = patterns.ValidateEmail("appu@gmail");
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

            bool result = patterns.ValidateMobileNumber("91 9876543212");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [TestMethod]
        public void GivenMobileNumber_WhenLessThanTenDigits_ShouldReturnFalse()
        {
            try
            {
                bool result = patterns.ValidateMobileNumber("89 2435462");
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
                bool result = patterns.ValidateMobileNumber("917654378967");
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

            bool result = patterns.ValidatePassword("sge#EEhw4");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenLessThanEightChracters_ShouldReturnFalse()
        {
            try
            {
                bool result = patterns.ValidatePassword("ste5SD");
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
                bool result = patterns.ValidatePassword("234%56");
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
                bool result = patterns.ValidatePassword("ase!df");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid password", e.Message);
            }
        }

        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenEmails_WhenChecked_ShouldReturnTrue(string email)
        {
            bool result = patterns.ValidateEmail(email);
            Assert.IsTrue(result);
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
                bool result = patterns.ValidateEmail(email);
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid mailID", e.Message);
            }
        }
    }
}