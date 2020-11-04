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
        /// Test Method to validate sample emails
        /// </summary>
        /// <param name="email"></param>
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

        /// <summary>
        /// Test Method to validate sample emails
        /// </summary>
        /// <param name="email"></param>
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
            bool result = patterns.ValidateEmail(email);
            Assert.IsFalse(result);
        }

    }
}