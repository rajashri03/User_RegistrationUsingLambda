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
            Assert.AreEqual("Raj", actual);
        }
        [TestMethod]
        public void LastNameShouldbeMatch()
        {
            //Act
            string actual = user.LastNameMatch("Mane");
            //Assert
            Assert.AreEqual("Mane", actual);
        }
    }
}