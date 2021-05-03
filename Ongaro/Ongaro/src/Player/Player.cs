using System;

namespace Ongaro.player
{
    public class Player : IPlayer
    {
        private string name;
        private int boardPosition;
        private readonly PlayerColor color;

        public Player(string name, PlayerColor color)
        {
            if ("".Equals(this.name))
            {
                throw new Exception();
            }

            this.name = name;
            this.color = color;
            boardPosition = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int BoardPosition => boardPosition;

        public void resetPosition()
        {
            boardPosition = 0;
        }

        public PlayerColor Color => color;


        public void addPosition(int value)
        {
            boardPosition += value;
        }

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   name == player.name &&
                   boardPosition == player.boardPosition &&
                   color == player.color &&
                   Name == player.Name &&
                   BoardPosition == player.BoardPosition &&
                   Color == player.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, boardPosition, color, Name, BoardPosition, Color);
        }


    }
}
