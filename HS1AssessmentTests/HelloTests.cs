using NUnit.Framework;
using NUnit.Framework.Internal;
using HS1Assessment.Controllers;

namespace HS1AssessmentTests
{
    [TestFixture]
    [Parallelizable]
    public class HelloTests
    {
        internal HelloController helloController = new();

        [SetUp]
        public void Setup()
        {
            Assume.That(helloController != null, "The hello controller was NULL!");
        }

        [Test]
        public void HelloEmptyName()
        {
            string response = helloController.HelloWorld("");
            Assert.IsTrue(response.Contains("Hello"), "The returned response did not contain 'Hello'");
        }

        [Test]
        [TestCase("Fred")]
        [TestCase("Barney Rubble")]
        [TestCase("W I L M A")]
        [TestCase("This_Is_A_Very_Long_Name_0123456789_0123456789_Do_You_Think_It_Is_Long_Enough")]
        [TestCase("NameWithSpecialCharacters_?!@#%^&*()+~")]
        [TestCase("Z")]
        public void HelloName(string name)
        {
            string response = helloController.HelloWorld(name);
            Assert.IsTrue(response.Contains(name), "The returned response did not contain: " + name);
        }

    }
}