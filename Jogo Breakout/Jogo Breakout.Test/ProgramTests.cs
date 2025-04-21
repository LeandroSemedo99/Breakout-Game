using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JogoBreakout.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void HelloWorldTest()
        {
            Assert.AreEqual("Hello, World!", "Hello, World!");
        }
    }
}