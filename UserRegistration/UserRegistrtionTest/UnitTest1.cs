using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_CustomException;

namespace UserRegistrtionTest
{
    [TestClass]
    public class UnitTest1
    {
        UserRegistration user = new UserRegistration();
        /// <summary>
        /// Test Method to check First Name is valid or not
        /// </summary>
        [TestMethod]
        public void FirstNameShouldbeMatch()
        {
            //Act
            string actual=user.FirstNameMatch("Raj");
            //Assert
            Assert.AreEqual("Name is Valid", actual);
        }
        /// <summary>
        /// Method to check last name is valid or not
        /// </summary>
        [TestMethod]
        public void LastNameShouldbeMatch()
        {
            //Act
            string actual = user.LastNameMatch("Mae");
            //Assert
            Assert.AreEqual("Last Name is valid", actual);
        }
        /// <summary>
        /// Method to check email is valid or not
        /// </summary>
        [TestMethod]
        public void EmailShouldbeValid()
        {
            //Act
            string actual = user.EmailMatch("abc.xyz@gmail.com");
            //Assert
            Assert.AreEqual("Email is Valid", actual);
        }
        /// <summary>
        /// Method to check Phone Number is valid or not
        /// </summary>
        [TestMethod]
        public void PhoneShouldbeValid()
        {
            //Act
            string actual = user.PhoneMatch("91 8898767890");
            //Assert
            Assert.AreEqual("Valid", actual);
        }
        /// <summary>
        /// Method to check password rule 1 is matched or not(minimum 8 character)
        /// </summary>
        [TestMethod]
        public void PasswordRule1ShouldbeMatch()
        {
            //Act
            string actual = user.PasswordRule1Match("rajas524");
            //Assert
            Assert.AreEqual("Password Validate", actual);
        }
        /// <summary>
        /// Method to check password rule 2 is matched or not(minimum 8 character and one uppercase letter)
        /// </summary>
        [TestMethod]
        public void PasswordRule2ShouldbeMatch()
        {
            //Act
            string actual = user.PasswordRule2Match("Rajas524");
            //Assert
            Assert.AreEqual("Password Validate", actual);
        }
    }
}