using Microsoft.AspNetCore.Rewrite.Internal;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using User_Registration;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace User_Registration_Test
{
    [TestClass]
    public class Test
    {
        private readonly User_Registration.Pattern patterns;

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

            bool result = patterns.ValidateFirstName("Ap");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenNotStartsWithCapAndMinThreeChar_ShouldReturnFalse()
        {

            bool result = patterns.ValidateFirstName("appU");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenAllLettersAreCapitalAndMinThreeChar_ShouldReturnFalse()
        {

            bool result = patterns.ValidateFirstName("APPU");
            Assert.IsFalse(result);
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

            bool result = patterns.ValidateLastName("Ra");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenLastName_WhenNotStartsWithCapAndMinThreeChar_ShouldReturnFalse()
        {

            bool result = patterns.ValidateLastName("raSal");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenLastName_WhenAllLettersAreCapitalAndMinThreeChar_ShouldReturnFalse()
        {

            bool result = patterns.ValidateLastName("RASAL");
            Assert.IsFalse(result);
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

            bool result = patterns.ValidateEmail("appu@gmail");
            Assert.IsFalse(result);
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

            bool result = patterns.ValidateMobileNumber("89 2435462");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [TestMethod]
        public void GivenMobileNumber_WhenNoSpaceAfterCountryCode_ShouldReturnFalse()
        {

            bool result = patterns.ValidateMobileNumber("917654378967");
            Assert.IsFalse(result);
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

            bool result = patterns.ValidatePassword("ste5SD");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenNotContainUpperCaseChar_ShouldReturnFalse()
        {

            bool result = patterns.ValidatePassword("234%56");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenNotContainNumericNumber_ShouldReturnFalse()
        {

            bool result = patterns.ValidatePassword("ase!df");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate given emails
        /// </summary>
        [TestMethod]
        public void GivenEmails_WhenChecked_ShouldReturnExpectedResult()
        {
            User_Registration.Pattern patterns = new User_Registration.Pattern();
            Assert.IsTrue(patterns.ValidateEmail("abc@yahoo.com"));
            Assert.IsTrue(patterns.ValidateEmail("abc-100@yahoo.com"));
            Assert.IsTrue(patterns.ValidateEmail("abc.100@yahoo.com"));
            Assert.IsTrue(patterns.ValidateEmail("abc111@abc.com"));
            Assert.IsTrue(patterns.ValidateEmail("abc-100@abc.net"));
            Assert.IsTrue(patterns.ValidateEmail("abc.100@abc.com.au"));
            Assert.IsTrue(patterns.ValidateEmail("abc@1.com"));
            Assert.IsTrue(patterns.ValidateEmail("abc@gmail.com.com"));
            Assert.IsTrue(patterns.ValidateEmail("abc+100@gmail.com"));
            Assert.IsFalse(patterns.ValidateEmail("abc"));
            Assert.IsFalse(patterns.ValidateEmail("abc123@gmail.a"));
            Assert.IsFalse(patterns.ValidateEmail("abc123@.com"));
            Assert.IsFalse(patterns.ValidateEmail("abc123@.com.com"));
            Assert.IsFalse(patterns.ValidateEmail(".abc@abc.com"));
            Assert.IsFalse(patterns.ValidateEmail("abc()*@gmail.com"));
            Assert.IsFalse(patterns.ValidateEmail("abc@%*.com"));
            Assert.IsFalse(patterns.ValidateEmail("abc..2002@gmail.com"));
            Assert.IsFalse(patterns.ValidateEmail("abc.@gmail.com"));
            Assert.IsFalse(patterns.ValidateEmail("abc@abc@gmail.com"));
            Assert.IsFalse(patterns.ValidateEmail("abc@gmail.com.2a"));
            Assert.IsFalse(patterns.ValidateEmail("abc@gmail.com.aa.au"));
        }
    }
}