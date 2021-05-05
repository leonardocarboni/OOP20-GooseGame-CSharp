
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
        public void TestEOModel()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                EOModel model = new EOModelImpll();
                Choice result = model.CheckWin(2);

                Assert.AreEqual(model.GetResult(), false);

                Assert.AreEqual(Choice.Pari, result);
                Assert.IsNotNull(model.GetResult());

                result = model.CheckWin(1);
                Assert.AreNotEqual(Choice.Pari, result);
                Assert.IsNotNull(model.GetResult());

                result = model.CheckWin(1);
                Assert.AreEqual(Choice.Dispari, result);
                Assert.IsNotNull(model.GetResult());

                result = model.CheckWin(2);
                Assert.AreNotEqual(Choice.Dispari, result);
                Assert.IsNotNull(model.GetResult());

            }
        }
    }
}
