namespace Ongaro.player
{
    public interface IPlayer
    {
        string Name { get; set; }
        PlayerColor Color { get; }

        int BoardPosition { get; }

        void addPosition(int value);

        void resetPosition();
    }
}