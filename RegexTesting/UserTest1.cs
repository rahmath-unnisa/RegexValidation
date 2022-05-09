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

    }
    
}