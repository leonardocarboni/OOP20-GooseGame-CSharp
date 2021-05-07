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
        /// 
        /// </summary>
        /// <returns></returns>
        public static RockPaperScissorsChoice GetRandomChoice()
        {
            Random rand = new Random();
            return (RockPaperScissorsChoice)rand.Next(0, 3);
        }

        public static void SetComputerChoice(RockPaperScissorsChoice choice)
        {
            rps = choice;
        }

        public static RockPaperScissorsChoice GetComputerChoice() 
        {
            return rps;
        }
    }
}