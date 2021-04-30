using System;

namespace OOP20_GooseGame_Carboni
{
    public class CableColor
    {
        private static readonly Random rand = new Random();

        private CableColor(string value) { ColorHex = value; }

        public string ColorHex { get; set; }

        /* To preserve the color hex the enums became public static variables 
         * where the hexcode can be returned via the get method.
         * (The hexCode is never used but it could be handy for a graphic implementation)
         */
        /**
         * Red color (#CF0000).
         */
        public static CableColor RED { get { return new CableColor("#CF0000"); } }
        /**
         * Blue color (#0000CF).
         */
        public static CableColor BLUE { get { return new CableColor("#0000CF"); } }
        /**
         * Green color (#00CF00).
         */
        public static CableColor GREEN { get { return new CableColor("#00CF00"); } }
        /**
         * Yellow color (#CFCF00).
         */
        public static CableColor YELLOW { get { return new CableColor("#CFCF00"); } }


        static CableColor[] Colors => new CableColor[] { RED, BLUE, GREEN, YELLOW };

        /**
         * Generates a random ordered array of colors.
         * @return a random ordered array of colors.
         */
        public static CableColor[] GetRandomColors()
        {
            
            CableColor[] randomColorsArray = Colors;

            //shuffle end colors array
            for (int i = 0; i < randomColorsArray.Length; i++)
            {
                int randomIndexToSwap = rand.Next(randomColorsArray.Length);
                CableColor temp = randomColorsArray[randomIndexToSwap];
                randomColorsArray[randomIndexToSwap] = randomColorsArray[i];
                randomColorsArray[i] = temp;
            }
            return randomColorsArray;
        }

        /**
         * Parses a CableColor to its Corrispondente ConsoleColor.
         */
        public static ConsoleColor ParseConsoleColor(CableColor color)
        {
            if (color.Equals(RED))
            {
                return ConsoleColor.Red;
            }
            else if (color.Equals(GREEN))
            {
                return ConsoleColor.Green;
            }
            else if (color.Equals(BLUE))
            {
                return ConsoleColor.Blue;
            }
            else
            {
                return ConsoleColor.Yellow;
            }
        }

        public bool Equals(CableColor other)
        {
            return this.ColorHex == other.ColorHex;
        }

    }

}
