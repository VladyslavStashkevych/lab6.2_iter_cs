using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramNS;

namespace TestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            int[] a = {1,2,3,4,5};
            int index = Program.MaxOddElement(a);
            Assert.AreEqual(4, index);
        }
    }
}
