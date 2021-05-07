using System;
using System.Collections.Generic;

namespace OOP20_GooseGame_Domi
{
    public enum ThreeCardGameChoice
    {
        /// <summary>
        /// SX_POS:
        /// </summary>
        SX_POS,

        /// <summary>
        /// CENTER_POS.
        /// </summary>
        CENTER_POS,

        /// <summary>
        /// DX_POS:
        /// </summary>
        DX_POS
    }

    public static class ThreeCardGameChoiceMethods
    {

        private static List<ThreeCardGameChoice> computerChoice;

        public static ThreeCardGameChoice GetRandomChoice() 
        {
            Random rand = new Random();
            return (ThreeCardGameChoice)rand.Next(0, 3);
        }

        public static void SetComputerChoice(List<ThreeCardGameChoice> choices) 
        {
            computerChoice = choices;
        }

        public static List<ThreeCardGameChoice> GetComputerChoice() 
        {
            return computerChoice;
        }
    }
}