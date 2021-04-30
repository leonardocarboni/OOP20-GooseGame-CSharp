using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP20_GooseGame_Carboni
{
    class Program
    {
        static void Main()
        {
            int choiche;
            Nullable<int> lastResult = null;
            do
            {
                choiche = InitializeConsole(lastResult);
                switch (choiche)
                {
                    case 1:
                        MinigameController phraseCatch = new PhraseCatchController();
                        lastResult = phraseCatch.getResult();
                        break;
                    case 2:
                        MinigameController cableConnect = new CableConnectController();
                        lastResult = cableConnect.getResult();
                        break;
                }
            } while (choiche != 3);
        }

        private static int InitializeConsole(int? lastResult)
        {
            Console.Clear();
            if (lastResult.HasValue)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Minigame Result: " + lastResult.Value);
                
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FiggleFonts.Slant.Render("GooseGame"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Phrase Catch");
            Console.WriteLine("2. Cable Connect");
            Console.WriteLine("3. Exit");
            Console.Write("Select The Minigame You Want to Play: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
