
using EOModelImpl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace EOTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /*
         * This test test the result of the casual number.
         */
        public void TestEOModel()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                EOModel model = new EOModelImpll();
                /*
                 * Result is even.
                 */
                Choice result = model.CheckWin(2);

                Assert.IsNotNull(model.GetResult());

                //win even
                Assert.AreEqual(Choice.Pari, result);
                Assert.IsNotNull(model.GetResult());

                //1 is not odd
                result = model.CheckWin(1);
                Assert.AreNotEqual(Choice.Pari, result);
                Assert.IsNotNull(model.GetResult());

                //1 is odd
                result = model.CheckWin(1);
                Assert.AreEqual(Choice.Dispari, result);
                Assert.IsNotNull(model.GetResult());

                //2 is not odd
                result = model.CheckWin(2);
                Assert.AreNotEqual(Choice.Dispari, result);
                Assert.IsNotNull(model.GetResult());

            }
        }
    }
}
