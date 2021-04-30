using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ongaro.player;
using Ongaro.queue;
using System.Collections.Generic;

namespace Ongaro
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void QueueTest2()
        {
            IQueue ql = new Queue();
            List<Player> list = new List<Player>();
            list.Add(new Player("Ciao", PlayerColor.PINK));
            list.Add(new Player("Ciao2", PlayerColor.PINK));
            list.Add(new Player("Ciao4", PlayerColor.PINK));
            ql.StartingQueue = list;
            ql.resetIterator();

            Assert.AreEqual<Player>(list[0], ql.next(), "Test");
            Assert.AreEqual(list[1], ql.next(), "Test");
            Assert.AreEqual(list[2], ql.next(), "Test");

            for (int i = 0; i < 3; i++)
            {
                ql.next();
            }

            Assert.AreEqual(list[2], ql.Current, "Test");
        }

        [TestMethod]
        public void QueueTest1()
        {
            IQueue ql = new Queue();
            Dictionary<Player, int> mapResult = new Dictionary<Player, int>();
            List<Player> listExpected = new List<Player>();
            Player p = new Player("Ciao", PlayerColor.PINK);
            Player p1 = new Player("Ciao2", PlayerColor.PINK);
            Player p2 = new Player("Ciao4", PlayerColor.PINK);

            mapResult.Add(p, 4);
            mapResult.Add(p1, 0);
            mapResult.Add(p2, 3);
            ql.orderPlayerQueue(mapResult);

            listExpected.Add(p);
            listExpected.Add(p2);
            listExpected.Add(p1);

            CollectionAssert.AreEqual(listExpected, ql.StartingQueue);
        }
        [TestMethod]
        
    }
}
