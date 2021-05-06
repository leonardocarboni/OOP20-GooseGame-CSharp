using Ongaro.box;
using Ongaro.exception;
using Ongaro.player;
using System.Collections.Generic;
using System.Linq;

namespace Ongaro.board
{
    public class Board : IBoard
    {
        private readonly int BOARD_LIMIT = 2;
        private readonly int MINIGAME_INTERVAL = 5;

        private int size;
        private List<Box> boxes;

        public int Size
        {
            set
            {
                if (value < BOARD_LIMIT)
                {
                    throw new IllegalArgumentException();
                }
                size = value;
                boxes = new List<Box>();
            }
        }
        public List<Box> GenerateBoard()
        {
            List<Box> minigames = getAllBoxesByType(BoxType.MINIGAMES);
            boxes.Add(Box.START);
            int minigameNumber = 0;
            for (int i = 1; i < size - 1; i++)
            {
                if (i % MINIGAME_INTERVAL == 0)
                {
                    minigameNumber = minigameNumber == minigames.Count ? 0 : minigameNumber;
                    boxes.Add(minigames.ElementAt(minigameNumber));
                    minigameNumber++;
                }
                else
                {
                    boxes.Add(Box.NORMAL);
                }
            }
            boxes.Add(Box.END);
            return boxes;
        }

        public Box GetBox(Player p)
        {
            return boxes.ElementAt(p.BoardPosition);
        }

        /// <summary>
        /// Get all boxes that matches the filter.
        /// </summary>
        /// <param name="type"> Type of Boxes to filter </param>
        /// <returns> list of boxes </returns>
        private List<Box> getAllBoxesByType(BoxType type)
        {
            List<Box> list = new List<Box>();
            foreach (Box b in Box.getBoxes())
            {
                if (b.boxType.Equals(type))
                {
                    list.Add(b);
                }
            }
            return list;
        }
    }
}
