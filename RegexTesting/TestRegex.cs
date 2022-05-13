using NUnit.Framework;
using ValidatingRegex;

namespace RegexTesting
{
    public class TestRegex
    {
        [Test]
        public void InputString_WhenTests_ShouldReturnFirstName()
        {
            UserValidation validation = new UserValidation();
            string actual = validation.ValidateFirstName("Manha");
            Assert.AreEqual(actual, "Manha");
        }
        [Test]
        public void InputString_WhenTests_ShouldReturnLastName()
        {
            UserValidation validation = new UserValidation();
            string actual = validation.ValidateLastName("Mehwish");
            Assert.AreEqual(actual, "Mehwish");
        }
        [Test]
        public void InputString_WhenTest_ShouldReturnEmail()
        {
            UserValidation validation = new UserValidation();
            string Email1 = validation.ValidateEmail("asfia.rehmath3400@gmail.co.in");
            Assert.AreEqual(Email1, "asfia.rehmath3400@gmail.co.in");
            string Email2 = validation.ValidateEmail("abc@yahoo.com");
            Assert.AreEqual(Email2, "abc@yahoo.com");
            string Email3 = validation.ValidateEmail("abc-100@yahoo.com");
            Assert.AreEqual(Email3, "abc-100@yahoo.com");
            string Email4 = validation.ValidateEmail("abc.100@yahoo.com");
            Assert.AreEqual(Email4, "abc.100@yahoo.com");
            string Email5 = validation.ValidateEmail("abc111@abc.com");
            Assert.AreEqual(Email5, "abc111@abc.com");
            string Email6 = validation.ValidateEmail("abc-100@abc.net");
            Assert.AreEqual(Email6, "abc-100@abc.net");
            string Email7 = validation.ValidateEmail("abc.100@abc.com.au");
            Assert.AreEqual(Email7, "abc.100@abc.com.au");
            string Email8 = validation.ValidateEmail("abc@1.com");
            Assert.AreEqual(Email8, "abc@1.com");
            string Email9 = validation.ValidateEmail("abc@gmail.com.com");
            Assert.AreEqual(Email9, "abc@gmail.com.com");
            string Email10 = validation.ValidateEmail("abc+100@gmail.com");
            Assert.AreEqual(Email10, "abc+100@gmail.com");


        }
        [Test]
        public void InputString_WhenTests_ShouldReturnMobileNumber()
        {
            UserValidation validation = new UserValidation();
            string actual = validation.ValidateMobileNumber("+91 7829986477");
            Assert.AreEqual(actual, "+91 7829986477");
        }
        [Test]
        public void InputString_WhenTest_ShouldReturnPassword()
        {
            UserValidation validation = new UserValidation();
            string actual = validation.ValidatePassword("Manha*1");
            Assert.AreEqual(actual, "Manha*1");
        }
    }
    
    
}