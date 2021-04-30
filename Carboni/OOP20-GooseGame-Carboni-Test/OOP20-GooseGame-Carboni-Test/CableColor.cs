using System;

namespace OOP20_GooseGame_Carboni_Test
{
    public class CableColor
    {
        private CableColor(string value) { ColorHex = value; }

        public string ColorHex { get; set; }

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


        static CableColor[] getColors()
        {
            return new CableColor[] { RED, BLUE, GREEN, YELLOW };
        }

        /**
         * Generates a random ordered array of colors.
         * @return a random ordered array of colors.
         */
        public static CableColor[] getRandomColors()
        {
            Random rand = new Random();
            CableColor[] randomColorsArray = getColors();

            //shuffle end colors array
            for (int i = 0; i < randomColorsArray.Length; i++)
            {
                int randomIndexToSwap = rand.Next(randomColorsArray.Length);
                CableColor temp = randomColorsArray[randomIndexToSwap];
                randomColorsArray[randomIndexToSwap] = randomColorsArray[i];
                randomColorsArray[i] = temp;
            }

            /*
            CableColor[] c = getColors();
            List<CableColor> inputList = c.ToList();
            CableColor[] output = new CableColor[c.Length];
            Random randomizer = new Random();
            int i = 0;

            while (inputList.Count > 0)
            {
                int index = randomizer.Next(inputList.Count);
                Console.WriteLine(index);
                output[i++] = inputList[index];
                inputList.RemoveAt(index);
            }*/
            /*
            Random rnd = new Random();

            CableColor[] randomColorsArray = getColors();
            randomColorsArray.OrderBy(x => rnd.Next()).ToArray();*/
            //Console.WriteLine(randomColorsArray[0].ColorHex + "  " + randomColorsArray[1].ColorHex + "  " + randomColorsArray[2].ColorHex + "  " + randomColorsArray[3].ColorHex);
            return randomColorsArray;
        }

        public static ConsoleColor parseConsoleColor(CableColor color)
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
