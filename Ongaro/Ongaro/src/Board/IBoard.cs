using Ongaro.box;
using Ongaro.player;
using System.Collections.Generic;

namespace Ongaro.board
{
    public interface IBoard
    {
        int Size { set; }

        List<Box> GenerateBoard();

        Box GetBox(Player p);
    }
}
