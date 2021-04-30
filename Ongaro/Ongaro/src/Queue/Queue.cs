using Ongaro.player;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ongaro.queue
{
    public class Queue : IQueue
    {
        private List<Player> startingQueue;
        private Player current;
        private IEnumerator playerIterator;
        public Player Current => current;

        public List<Player> StartingQueue
        {
            set { startingQueue = deepCopy(value); }
            get => startingQueue;
        }
        public Player next()
        {
            if (!playerIterator.MoveNext())
            {
                resetIterator();
                next();
            }
            current = (Player)playerIterator.Current;
            return current;
        }

        public void orderPlayerQueue(Dictionary<Player, int> diceThrowing)
        {
            startingQueue = new List<Player>();
            var myList = diceThrowing.ToList();
            myList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            myList.ForEach(x => startingQueue.Add(x.Key));
        }

        public void resetIterator()
        {
            playerIterator = startingQueue.GetEnumerator();
        }

        /**
         * Create a deep copy of the list to avoid problem when list passed as parameter
         * will change.
         * @param list
         * @return list of players
         */
        private List<Player> deepCopy(List<Player> players)
        {
            return players.ConvertAll(x => new Player(x.Name, x.Color));
        }
    }
}
