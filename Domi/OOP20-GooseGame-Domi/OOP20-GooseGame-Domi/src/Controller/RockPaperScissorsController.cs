using System;

namespace OOP20_GooseGame_Domi
{
    public class RockPaperScissorsController
    {
        private readonly RockPaperScissorsView view;
        private int numPlayerWin;
        private int numComputerWin;
        private int numTurns;

        public RockPaperScissorsController()
        {
            view = new RockPaperScissorsView();
        }

        //...
    }
}