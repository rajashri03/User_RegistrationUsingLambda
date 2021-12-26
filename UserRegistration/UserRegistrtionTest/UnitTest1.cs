using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_CustomException;

namespace UserRegistrtionTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test Method to check First Name is valid or not
        /// </summary>
        [TestMethod]
        public void FirstNameShouldbeMatch()
        {
            //Arrange
            UserRegistration user = new UserRegistration();
            //Act
            string actual=user.FirstNameMatch("Raj");
            //Assert
            Assert.AreEqual("Raj", actual);
        }
    }
}