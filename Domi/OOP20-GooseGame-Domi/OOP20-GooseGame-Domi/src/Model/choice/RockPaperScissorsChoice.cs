using System;

namespace OOP20_GooseGame_Domi
{
    public enum RockPaperScissorsChoice 
    {
        /// <summary>
        /// ROCK:
        /// </summary>
        ROCK,
        /// <summary>
        /// PAPER.
        /// </summary>
        PAPER,
        /// <summary>
        /// SCISSORS.
        /// </summary>
        SCISSORS
    }

    

    static class RockPaperScissorsChoiceMethods
    {

        private static RockPaperScissorsChoice rps;

        /// <summary>
        /// Gets a random choice.
        /// </summary>
        /// <returns></returns>
        public static RockPaperScissorsChoice GetRandomChoice()
        {
            Random rand = new Random();
            return (RockPaperScissorsChoice)rand.Next(0, 3);
        }

        /// <summary>
        /// Is use for testing.
        /// Creates hypothetical computer choice.
        /// </summary>
        /// <param name="choice" between enum component></param>
        public static void SetComputerChoice(RockPaperScissorsChoice choice)
        {
            rps = choice;
        }

        /// <summary>
        /// Is use for testing.
        /// </summary>
        /// <returns>choice sets in SetComputerChoice</returns>
        public static RockPaperScissorsChoice GetComputerChoice() 
        {
            return rps;
        }
    }
}