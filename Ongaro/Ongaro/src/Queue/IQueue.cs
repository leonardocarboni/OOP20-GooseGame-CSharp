using Ongaro.player;
using System.Collections.Generic;

namespace Ongaro.queue
{
    interface IQueue
    {
        /**
         * Get current player.
         * 
         * @return current player
         */
        Player Current { get; }
        /**
         * Get starting queue.
         * Set starting player queue.
         * @return list of players
         */
        List<Player> StartingQueue { get; set; }
        /**
         * Set playerQueue with map keys and ordering using map values.
         * 
         * @param diceThrowing
         */
        void orderPlayerQueue(Dictionary<Player, int> diceThrowing);

        /**
         * Reset the queue at the starting point. Useful when change the player queue
         */
        void resetIterator();

        /**
         * Get next player in the iterator. 
         * @return a player
         */
        Player next();
    }
}
