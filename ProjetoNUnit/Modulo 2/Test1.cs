using NUnit.Framework;

namespace ProjetoNUnit
{
    public class Tests
    {
       

        [TestCase(1,4)]
        [Category("Test")]

        public void Test1(int x, int y)
        {
            Assert.AreEqual(5, x+y);
        }

        [Test]
        public void Test2()
        {
            string banda = "Pink Floyd";       
            Assert.IsTrue(banda.Equals("Pink Floyd"));
        }

        [Test]
        public void Test3()
        {
            string banda = "Pink Floyd";
            Assert.AreEqual("Pink Floyd", banda);
        }

        [Test]
        public void Test4()
        {
            string banda = "Pink Floyd";
            Assert.IsFalse(banda.Equals("Massacration"));
        }
    }
}