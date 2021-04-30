using System.Collections.Generic;
using System.Linq;

namespace OOP20_GooseGame_Carboni
{
    class CableConnectController : MinigameController
    {
        private readonly int CABLES = 4;
        private readonly CableConnectView view;
        private readonly int errors = 0;

        public CableConnectController()
        {
            List<CableColor> colorsDone = new List<CableColor>();
            view = new CableConnectView(CABLES);

            CableColor[] startColorsArray = CableColor.GetRandomColors();
            CableColor[] endColorsArray = CableColor.GetRandomColors();

            view.InitializeButtonsMap(startColorsArray, endColorsArray);

            while (colorsDone.Count < CABLES)
            {
                view.PrintCables(colorsDone);

                bool checkStartFound, checkEndFound;
                CableColor startColor;
                CableColor colorDone;
                bool check = false;

                do
                {
                    string choice = view.GetChoice();
                    string startChoice = choice.First().ToString();
                    string endChoice = choice.Last().ToString();

                    checkStartFound = view.CheckStartColor(startChoice, out startColor);
                    checkEndFound = view.CheckEndColor(endChoice, out CableColor endColor);

                    if (checkStartFound && checkEndFound && startColor.Equals(endColor))
                        check = true;
                    else
                    {
                        errors++;
                        view.PrintError();
                    }
                } while (!check);
                colorDone = startColor;
                colorsDone.Add(colorDone);

            }

        }

        public int getResult()
        {
            /*
             * the game the result is based on the remaining time
             * and the errors made 
             * due to the fact that the timer could not be implemented
             * it returns -errors made
             */
            return -errors;
        }
    }
}
