using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP20_GooseGame_Carboni_Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void PhraseTest()
        {
            IPhrase p = new PhraseImpl();
            p.SetPhrase("My sentence is correct - 12345");

            Assert.AreEqual(0, p.CheckText("My sentence is correct - 12345"));
            //missing "5" (replaced with "6")
            Assert.AreEqual(1, p.CheckText("My sentence is correct - 12346"));
            //missing "345"
            Assert.AreEqual(3, p.CheckText("My sentence is correct - 12"));
            //missing "correct - 12345" [15 chars] replaced with "wrong - 12345" [13 chars]
            /*  notice how the space after "-" in the wrong sentence is in the same position as
                the space before "-" in the correct sentence (not counted as an error)  */
            Assert.AreEqual(14, p.CheckText("My sentence is wrong - 12345"));
            //missing "correct - 12345" [15 chars] replaced with "wrong_-_12345" [13 chars]
            Assert.AreEqual(15, p.CheckText("My sentence is wrong_-_12345"));
            //missing "correct" replaced with "CORRECT" [only 7 chars missing, the others are the same]
            Assert.AreEqual(7, p.CheckText("My sentence is CORRECT - 12345"));
            //more charters than expected (counted as errors)
            Assert.AreEqual(3, p.CheckText("My sentence is correct - 12345678"));
        }

        [TestMethod]
        public void CableColorTest()
        {
            //shows that it only works with the Equals check because CableColor.BLUE is not an
            //enum but it's a static istance of the object CableColor
            Assert.AreNotEqual(CableColor.BLUE, CableColor.BLUE);
            Assert.IsTrue(CableColor.BLUE.Equals(CableColor.BLUE));
            //checks if they return in correct order
            CableColor[] colors = CableColor.GetColors();
            Assert.IsTrue(colors[0].Equals(CableColor.RED));
            Assert.IsTrue(colors[1].Equals(CableColor.BLUE));
            Assert.IsTrue(colors[2].Equals(CableColor.GREEN));
            Assert.IsTrue(colors[3].Equals(CableColor.YELLOW));
        }
    }
}
