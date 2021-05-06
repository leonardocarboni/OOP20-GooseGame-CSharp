using Ongaro.dice;
using Ongaro.player;
using Ongaro.queue;
using System.Collections.Generic;

namespace Ongaro.game
{
    /**
     * A simplified class of Game
     */
    class Game : IGame
    {
        private static readonly int BOARD_SIZE = 42;
        private readonly IDice dice;
        private readonly IQueue playerQueue;
        private StateGame gameState;
        public Game()
        {
            playerQueue = new Queue();
            dice = new Dice();
            gameState = StateGame.START;
        }
        public void Start(List<IPlayer> playerList)
        {
            gameState = StateGame.CHOOSE_STARTING_QUEUE;
            playerQueue.StartingQueue = playerList;
            playerQueue.resetIterator();
        }

        public int RollCurrentPlayer()
        {
            int diceValue = dice.roll();
            playerQueue.Current.addPosition(diceValue);
            return diceValue;
        }

        public StateGame GameState => gameState;

        public bool EndGame()
        {
            gameState = playerQueue.Current.BoardPosition >= BOARD_SIZE - 1 ? StateGame.END : StateGame.CONTINUE;
            return gameState.Equals(StateGame.END);
        }
    }
}
