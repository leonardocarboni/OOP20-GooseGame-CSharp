using Ongaro.player;
using System.Collections.Generic;

namespace Ongaro.game
{
    interface IGame
    {
        /// <summary>
        /// Initialize game.
        /// </summary>
        /// <param name="playerList"> list of all players </param>
        void Start(List<IPlayer> playerList);

        /// <summary>
        /// Create the starting queue.
        /// </summary>
        /// <returns> Value of the dice roll for current player</return>
        int RollCurrentPlayer();

        /// <summary>
        /// Get State Game.
        /// </summary>
        /// <returns> Enum with current state of game </returns>
        StateGame GameState { get; }

        /// <summary>
        /// Check if the game is ended.
        /// </summary>
        /// <returns> true if game is ended otherwise false </returns>
        bool EndGame();
    }
}
