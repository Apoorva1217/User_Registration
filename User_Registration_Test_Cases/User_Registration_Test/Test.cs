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
        private readonly Patterns patterns;

        public Test()
        {
            patterns = new User_Registration.Patterns();
        }
     
        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenStartsWithCapAndMinThreeChar_ShouldReturnTrue()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateFirstName("Appu");

            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnTrue()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateFirstName("Ap");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenNotStartsWithCapAndMinThreeChar_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateFirstName("appU");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        public void GivenFirstName_WhenAllLettersAreCapitalAndMinThreeChar_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateFirstName("APPU");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenLastName_WhenStartsWithCapAndMinThreeChar_ShouldReturnTrue()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateLastName("Rasal");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenlastName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateLastName("Ra");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenLastName_WhenNotStartsWithCapAndMinThreeChar_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateLastName("raSal");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [TestMethod]
        public void GivenLastName_WhenAllLettersAreCapitalAndMinThreeChar_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateLastName("RASAL");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate email
        /// </summary>
        [TestMethod]
        public void GivenEmailId_WhenProper_ShouldReturnTrue()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateEmail("Appu12@gmail.com");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate email
        /// </summary>
        [TestMethod]
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateEmail("appu@gmail");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [TestMethod]
        public void GivenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateMobileNumber("91 9876543212");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [TestMethod]
        public void GivenMobileNumber_WhenLessThanTenDigits_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateMobileNumber("89 2435462");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [TestMethod]
        public void GivenMobileNumber_WhenNoSpaceAfterCountryCode_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidateMobileNumber("917654378967");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenWithMinimumEightChracters_ShouldReturnTrue()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidatePassword("sge#EEhw4");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenLessThanEightChracters_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidatePassword("ste5SD");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenNotContainUpperCaseChar_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidatePassword("234%56");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [TestMethod]
        public void GivenPassword_WhenNotContainNumericNumber_ShouldReturnFalse()
        {
            Patterns patterns = new Patterns();
            bool result = patterns.ValidatePassword("ase!df");
            Assert.IsFalse(result);
        }
    }
}
