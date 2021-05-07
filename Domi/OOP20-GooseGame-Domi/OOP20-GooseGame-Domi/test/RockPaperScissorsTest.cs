using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP20_GooseGame_Domi
{
    [TestClass]
    public class RockPaperScissorsTest
    {
        private static RockPaperScissorsChoice rps;

        [TestMethod]
        public void CheckWinner()
        {
            RockPaperScissorsChoiceMethods.SetComputerChoice(RockPaperScissorsChoice.ROCK);
            rps = RockPaperScissorsChoiceMethods.GetRandomChoice();

            Assert.AreEqual(RockPaperScissorsChoice.ROCK, rps);
            Assert.AreEqual(RockPaperScissorsChoice.PAPER, rps);
            Assert.AreEqual(RockPaperScissorsChoice.SCISSORS, rps);
        }
        
    }
}