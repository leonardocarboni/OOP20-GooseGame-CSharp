using System;

namespace Ongaro.dice
{
    class Dice : IDice
    {
        private static readonly int MIN_VALUE_DICE = 1;
        private static readonly int MAX_VALUE_DICE = 6;

        public int roll()
        {
            return new Random().Next(MIN_VALUE_DICE, MAX_VALUE_DICE);
        }
    }
}
