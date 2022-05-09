using NUnit.Framework;
using ValidatingRegex;

namespace RegexTesting
{
        public class Tests
        {

            [Test]
            public void FirstName()
            {
                NameValidation validation = new NameValidation();
                string actual = validation.FirstName("Manha");
                Assert.AreEqual(actual, "Manha");
            }

        }
    
}