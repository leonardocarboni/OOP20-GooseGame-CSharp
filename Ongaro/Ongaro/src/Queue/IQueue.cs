using Ongaro.player;
using System.Collections.Generic;

namespace Ongaro.queue
{
    interface IQueue
    {
        /// <summary>
        /// Get current player.
        /// </summary>
        /// <returns> current player </returns>
        IPlayer Current { get; }

        /// <summary>
        /// Get & set starting queue.
        /// </summary>
        /// <returns> list of players </returns>
        List<IPlayer> StartingQueue { get; set; }

        /// <summary>
        /// Set playerQueue with map keys and ordering using map values.
        /// </summary>
        /// <param name="diceThrowing"> collection that contains all initial dice value for every player </param>
        void orderPlayerQueue(Dictionary<IPlayer, int> diceThrowing);

        /// <summary>
        /// Reset the queue at the starting point. Useful when change the player queue
        /// </summary>
        void resetIterator();

        /// <summary>
        /// Get next player in the iterator. 
        /// </summary>
        /// <returns> a player </returns>
        IPlayer next();
    }
}
