using System;

namespace OOP20_GooseGame_Carboni
{
    internal class PhraseCatchView
    {
        public void SetPhrase(string sentence)
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(sentence + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal string GetInputPhrase()
        {
            string inputText;
            do
            {
                Console.Write("Insert your phrase: ");
                inputText = Console.ReadLine();
                if (inputText == "")
                {
                    Console.WriteLine("You have to insert a phrase!");
                }
            } while (inputText == "");
            
            return inputText;
        }
    }
}