using Ongaro.box;
using Ongaro.player;
using System.Collections.Generic;

namespace Ongaro.board
{
    public interface IBoard
    {
        /// <summary>
        /// Set size of board.
        /// </summary>
        /// <exception cref="IllegalArgumentException"> Launch when value is less then 2</exception> 
        /// <param name="value"> </param>
        int Size { set; }

        /// <summary>
        /// Create the board of game.
        /// </summary>
        /// <returns> list of boxes </returns>
        List<Box> GenerateBoard();

        /// <summary>
        /// Get type of box where the player is above now.
        /// </summary>
        /// <param name="p"> player </param>
        /// <returns> type of the box </returns>
        Box GetBox(Player p);
    }
}
