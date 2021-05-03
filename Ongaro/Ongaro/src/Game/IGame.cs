using Ongaro.player;
using System.Collections.Generic;

namespace Ongaro.game
{
    interface IGame
    {
        void Start(List<IPlayer> playerList);

        int RollCurrentPlayer();

        StateGame GameState { get; }

        bool EndGame();
    }
}
