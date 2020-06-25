using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibUnderTest.Tets
{
    [TestClass]
    public class Class1Tests
    {
        [TestMethod]
        public void addTest()
        {
            var c = new Class1();
            Assert.AreEqual(2, c.add(1, 1));
        }

        //[TestMethod]
        //public void addTestExtended()
        //{
        //    var c = new Class1();
        //    Assert.AreEqual(20, c.add(11, 3));
        //}
    }
}
