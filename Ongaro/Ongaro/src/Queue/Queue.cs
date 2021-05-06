using Ongaro.player;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ongaro.queue
{
    public class Queue : IQueue
    {
        private List<IPlayer> startingQueue;
        private IPlayer current;
        private IEnumerator playerIterator;

        public IPlayer Current => current;

        public List<IPlayer> StartingQueue
        {
            set { startingQueue = value; }
            get => startingQueue;
        }

        public IPlayer next()
        {
            if (!playerIterator.MoveNext())
            {
                resetIterator();
            }
            current = (Player)playerIterator.Current;
            return current;
        }

        public void orderPlayerQueue(Dictionary<IPlayer, int> diceThrowing)
        {
            startingQueue = new List<IPlayer>();
            var myList = diceThrowing.ToList();
            myList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            myList.ForEach(x => startingQueue.Add(x.Key));
        }

        public void resetIterator()
        {
            playerIterator = startingQueue.GetEnumerator();
            current = next();
        }
    }
}
