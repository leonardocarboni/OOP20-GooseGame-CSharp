using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP20_GooseGame_Domi
{
    [TestClass]
    public class ThreeCardTest
    {
        private static readonly ThreeCardGameChoice RIGHT_CHOISE = ThreeCardGameChoice.SX_POS;
        private static readonly ThreeCardGameChoice WRONG_CHOISE_1 = ThreeCardGameChoice.CENTER_POS;
        private static readonly ThreeCardGameChoice WRONG_CHOISE_2 = ThreeCardGameChoice.DX_POS;

        private static List<ThreeCardGameChoice> hypoteticalChoices = new();
        private static List<ThreeCardGameChoice> computerChoices = new();

        public void PopulateLists()
        {
            computerChoices.Add(RIGHT_CHOISE);
            computerChoices.Add(WRONG_CHOISE_1);
            computerChoices.Add(WRONG_CHOISE_2);
            hypoteticalChoices.Add(ThreeCardGameChoice.SX_POS);
            hypoteticalChoices.Add(ThreeCardGameChoice.CENTER_POS);
            hypoteticalChoices.Add(ThreeCardGameChoice.DX_POS);
        }

        [TestMethod]
        public void CheckWin()
        {
            PopulateLists();
            ThreeCardGameChoiceMethods.SetComputerChoice(hypoteticalChoices);
            var choices = ThreeCardGameChoiceMethods.GetComputerChoice();

            Assert.AreEqual(RIGHT_CHOISE, choices.ElementAt(0));
            Assert.AreNotEqual(RIGHT_CHOISE, choices.ElementAt(1));
            Assert.AreNotEqual(RIGHT_CHOISE, choices.ElementAt(2));
        }

        [TestMethod]
        public void CheckLose()
        {
            PopulateLists();
            ThreeCardGameChoiceMethods.SetComputerChoice(hypoteticalChoices);
            var choices = ThreeCardGameChoiceMethods.GetComputerChoice();

            Assert.AreNotEqual(WRONG_CHOISE_1, choices.ElementAt(0));
            Assert.AreNotEqual(WRONG_CHOISE_2, choices.ElementAt(0));

            Assert.AreNotEqual(WRONG_CHOISE_2, choices.ElementAt(1));
            Assert.AreNotEqual(WRONG_CHOISE_1, choices.ElementAt(2));
        }
    }
}