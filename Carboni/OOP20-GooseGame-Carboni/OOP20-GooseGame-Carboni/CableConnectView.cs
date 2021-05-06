using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OOP20_GooseGame_Carboni
{
    class CableConnectView
    {
        private readonly int CABLES = 0;
        private readonly string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly Dictionary<string, CableColor> startButtonsMap = new Dictionary<string, CableColor>();
        private readonly Dictionary<string, CableColor> endButtonsMap = new Dictionary<string, CableColor>();

        public CableConnectView(int cables) => CABLES = cables;

        ///<summary>Initializes the dictionaries.</summary>
        ///<param name="startColorsArray">The start colors order</param>
        ///<param name="endColorsArray">The end colors order</param>
        internal void InitializeButtonsMap(CableColor[] startColorsArray, CableColor[] endColorsArray)
        {
            int i = 0;
            foreach (CableColor c in startColorsArray)
            {
                i++;
                startButtonsMap.Add(i.ToString(), c);
            }
            i = 0;
            foreach (CableColor c in endColorsArray)
            {
                i++;
                endButtonsMap.Add(ALPHABET[i % ALPHABET.Length - 1].ToString(), c);
            }
        }

        ///<summary>Reads a choice expressed in style [NUM][CAPITAL_LETTER] and checks
        ///if it's not already done or written in non compatible format.</summary>
        ///<returns>a string formatted [0X]</returns>
        internal string GetChoice()
        {
            bool check = false;
            string choice;
            do
            {
                Console.Write("Insert choice [format 0X]: ");
                choice = Console.ReadLine();

                if (Regex.IsMatch(choice, @"[0-9][A-Z]"))
                {
                    check = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("The format must be 0X");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (!check);

            return choice;
        }


        ///<summary>Prints the cables in the Console (Coloured).</summary>
        ///<param name="colorsDone">The colors that must be excluded from printing</param>
        internal void PrintCables(List<CableColor> colorsDone)
        {
            for (int i = 0; i < CABLES; i++)
            {
                CableColor start = startButtonsMap.ElementAt(i).Value;

                if (!ListContains(colorsDone, start))
                {
                    Console.ForegroundColor = CableColor.ParseConsoleColor(start);
                    Console.Write(startButtonsMap.ElementAt(i).Key);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write(" ");
                }

                Console.Write("\t\t\t\t");
                CableColor end = endButtonsMap.ElementAt(i).Value;
                if (!ListContains(colorsDone, end))
                {
                    Console.ForegroundColor = CableColor.ParseConsoleColor(end);
                    Console.WriteLine(endButtonsMap.ElementAt(i).Key);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }
        }

        ///<summary>Checks if a List<CableColor> contains a color with Equals method.</summary>
        ///<param name="list">The list in witch you want to check if the color is inside</param>
        ///<param name="color">The color you want to check</param>
        ///<returns>true if the color is insiede the list</returns>
        private bool ListContains(List<CableColor> list, CableColor color)
        {
            foreach (CableColor c in list)
            {
                if (c.Equals(color))
                {
                    return true;
                }
            }
            return false;
        }

        ///<summary>Checks if a number can be associated with a color.</summary>
        ///<param name="choice">The user's choice for the end positions format "0"</param>
        ///<param name="color">[out] color retrived from TryGetValue</param>
        ///<returns>true if the coiche can be parsed to a color</returns>
        public bool CheckStartColor(string choice, out CableColor color)
        {
            return startButtonsMap.TryGetValue(choice, out color);
        }

        ///<summary>Checks if a char can be associated with a color.</summary>
        ///<param name="choice">The user's choice for the end positions format "X"</param>
        ///<param name="color">out color retrived from TryGetValue</param>
        ///<returns>true if the coiche can be parsed to a color</returns>
        public bool CheckEndColor(string choice, out CableColor color)
        {
            return endButtonsMap.TryGetValue(choice, out color);
        }

        /// <summary>prints an error saying "wrong connection"</summary>
        public void PrintError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong connection!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}