using NUnit.Framework;
using ValidatingRegex;

namespace RegexTesting
{
    public class UserTest1
    {

        [Test]
        public void FirstName()
        {
            UserValidation validation = new UserValidation();
            string actual = validation.FirstName("Manha");
            Assert.AreEqual(actual, "Manha");
        }
        [Test]
        public void LastName()
        {
            UserValidation validation = new UserValidation();
            string actual = validation.LastName("Mehwish");
            Assert.AreEqual(actual, "Mehwish");
        }
        [Test]
        public void Email()
        {
            UserValidation validation = new UserValidation();
            string actual = validation.EmailValidation("asfiarehmath@gmail.com");
            Assert.AreEqual(actual, "asfiarehmath@gmail.com");
        }
        [Test]
        public void MobileNumber()
        {
            UserValidation validation = new UserValidation();
            string actual = validation.ValidateMobileNumber("9158719379");
            Assert.AreEqual(actual, "9158719379");
        }
        [Test]
        public void Password()
        {
            UserValidation validation = new UserValidation();
            string actual = validation.PasswordValidation("Asfia777");
            Assert.AreEqual(actual, "Asfia777");
        }
    }
    
    
}