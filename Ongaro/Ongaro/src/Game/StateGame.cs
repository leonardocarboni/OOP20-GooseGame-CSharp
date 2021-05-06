namespace Ongaro.game
{
    enum StateGame
    {
        /// <summary>
        /// Start Type used to initialize game.
        /// </summary>
        START,

        /// <summary>
        /// Phrase where players roll dice to choose starting queue.
        /// </summary>
        CHOOSE_STARTING_QUEUE,

        /// <summary>
        /// Phrase where all players play.
        /// </summary>
        CONTINUE,

        /// <summary>
        /// End Phrase.
        /// </summary>
        END
    }
}
