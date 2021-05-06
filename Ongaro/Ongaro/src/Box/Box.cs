using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ongaro.box
{
    public class Box : EnumBaseType<Box>
    {
        public static readonly Box START = new Box(1, "Start", BoxType.NORMAL);
        public static readonly Box NORMAL = new Box(2, "Normal", BoxType.NORMAL);
        public static readonly Box END = new Box(3, "End", BoxType.NORMAL);
        public static readonly Box TICTACTOE = new Box(4, "TICTACTOE", BoxType.MINIGAMES);
        public static readonly Box EVEN_OR_ODD = new Box(5, "EVEN_OR_ODD", BoxType.MINIGAMES);
        public static readonly Box ROCK_PAPER_SCISSORS = new Box(6, "ROCK_PAPER_SCISSORS", BoxType.MINIGAMES);
        public static readonly Box CABLE_CONNECT = new Box(7, "CABLE_CONNECT", BoxType.MINIGAMES);
        public static readonly Box PHRASE_CATCH = new Box(7, "PHRASE_CATCH", BoxType.MINIGAMES);

        public readonly BoxType boxType;

        public Box(int key, string value, BoxType type) : base(key, value)
        {
            this.boxType = type;
        }

        /// <summary>
        /// Get all type of box
        /// </summary>
        /// <returns> list of box</returns>
        public static List<Box> getBoxes()
        {
            List<Box> list = new List<Box>();
            list.Add(START);
            list.Add(NORMAL);
            list.Add(END);
            list.Add(TICTACTOE);
            list.Add(EVEN_OR_ODD);
            list.Add(ROCK_PAPER_SCISSORS);
            list.Add(CABLE_CONNECT);
            list.Add(PHRASE_CATCH);
            return list;
        }
    }
}
