using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ongaro.game;
using Ongaro.player;
using System.Collections.Generic;

namespace Ongaro.test
{
    [TestClass]
    public class GameTest
    {
        private static readonly int BOARD_SIZE = 42;
        [TestMethod]
        public void TestGame()
        {
            IGame g = new Game();
            List<IPlayer> list = new List<IPlayer>();
            list.Add(new Player("Ciao", PlayerColor.PINK));
            list.Add(new Player("Ciao2", PlayerColor.PINK));
            list.Add(new Player("Ciao4", PlayerColor.PINK));

            g.Start(list);
            Assert.IsFalse(g.EndGame());
            do
            {
                g.RollCurrentPlayer();
            } while (!g.EndGame());

            Assert.IsTrue(g.EndGame());
            Assert.IsTrue(list[0].BoardPosition >= BOARD_SIZE);
        }
    }
}
