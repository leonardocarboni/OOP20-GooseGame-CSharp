using System;

namespace OOP20_GooseGame_Domi
{
    public class ThreeCardController 
    {
        private readonly ThreeCardGameView view;
        private ThreeCardGameChoice playerChoice, computerChoice;

        private int numPlayerWin;
        private int numComputerWin;
        private int numTurns;

        public ThreeCardController() 
        {
            view = new ThreeCardGameView();
        }

        //...
    }
}