namespace Ongaro.player
{
    public interface IPlayer
    {
        /// <summary>
        /// Get and set name of player.
        /// </summary> 
        string Name { get; set; }

        /// <summary>
        /// Get color of the player.
        /// </summary>
        PlayerColor Color { get; }

        /// <summary>
        /// Get actual board position of the player.
        /// </summary>
        int BoardPosition { get; }

        /// <summary>
        /// Add dice result to current position of the player.
        /// </summary>
        /// <param name="value"> value of dice roll</param>
        void addPosition(int value);

        /// <summary>
        /// Set position of the player to 0.
        /// </summary>
        void resetPosition();
    }
}