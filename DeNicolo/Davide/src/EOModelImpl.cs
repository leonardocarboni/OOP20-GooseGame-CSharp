using System;
/**
* Implementation of {@link EOModel} MODEL.
*/

namespace EOModelImpl
{

    public class EOModelImpll : EOModel
    {

        private bool result = false;
        public bool Result
        {
            set { result = value; }
            get { return result; }
        }

        public Choice CheckWin(int value)
        {
            /**
             * Generate the random value.
             */
            Random rnd = new Random();
            int rndValue = rnd.Next(0, 10);

            if ((value == 2 && rndValue % 2 == 0) || (value == 1 && rndValue % 2 != 0))
            {
                result = true;
            }
            if (value == 1)
            {
                return Choice.Dispari;
            }
            else
            {
                return Choice.Pari;
            }


        }

        public bool GetResult()
        {
            return result;
        }

    }
}
