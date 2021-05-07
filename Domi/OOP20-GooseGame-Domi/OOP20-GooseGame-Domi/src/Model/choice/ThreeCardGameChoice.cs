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

        /// <summary>
        /// Get a random choice.
        /// </summary>
        /// <returns>choice</returns>
        public static ThreeCardGameChoice GetRandomChoice() 
        {
            Random rand = new Random();
            return (ThreeCardGameChoice)rand.Next(0, 3);
        }

        /// <summary>
        /// Is use for testing.
        /// Creates a list of hypothetical choices.
        /// </summary>
        /// <param name="choices"></param>
        public static void SetComputerChoice(List<ThreeCardGameChoice> choices) 
        {
            computerChoice = choices;
        }

        /// <summary>
        /// Is use for testing.
        /// </summary>
        /// <returns>choices set in setComputerChoice</returns>
        public static List<ThreeCardGameChoice> GetComputerChoice() 
        {
            return computerChoice;
        }
    }
}