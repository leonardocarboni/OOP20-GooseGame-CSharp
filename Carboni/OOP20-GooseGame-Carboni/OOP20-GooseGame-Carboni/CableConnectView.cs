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

        /**
         * Initializes the dictionaries.
         */
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

        /**
         * Reads a choice expressed in style [NUM][CAPITAL_LETTER] and checks
         * if it's not already done or written in non compatible format.
         */
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
                } else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("The format must be 0X");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (!check);

            return choice;
        }

        /**
         * Prints the cables in the Console (Coloured).
         */
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

        /**
         * Checks if a List<CableColor> contains a color with Equals method.
         */
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

        /**
         * Checks if a number can be associated with a color
         */
        public bool CheckStartColor(string choice, out CableColor color)
        {
            return startButtonsMap.TryGetValue(choice, out color);
        }

        /**
         * Checks if a char can be associated with a color
         */
        public bool CheckEndColor(string choice, out CableColor color)
        {
            return endButtonsMap.TryGetValue(choice, out color);
        }

        public void PrintError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong connection!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}