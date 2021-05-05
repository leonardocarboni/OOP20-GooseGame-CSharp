using System;
using System.Collections.Generic;

/**
* Model of the game. {@link TTTModel}
*/
public class TTTModelImpl
{

    public int numberOfClick;

    /**
    * This is the grid dim, used for algorithm.
    */
    private int bound;

    private readonly List<string> sign = new List<string>();

    private List<string> buttonOnTheGrid = new List<string>();

    public TTTModelImpl(List<string> buttonOnTheGrid)
    {
        this.numberOfClick = 0;
        this.bound = 3;
        this.buttonOnTheGrid = buttonOnTheGrid;
    }

    public string CheckWin()
    {
        numberOfClick++;
        for (int i = 0; i <= (bound) * (bound - 1); i += bound)
        {
            for (int j = 0; j < 2; j++)
            {
                int counter = 0;
                for (int k = 0; k < bound; k++)
                {
                    if (buttonOnTheGrid[i + k] == (sign[j]))
                    {
                        counter++;
                    }
                    if (counter == bound)
                    {
                        Clear();
                        return sign[j];
                    }
                }
            }
        }
        for (int i = 0; i < bound; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                int counter = 0;
                for (int k = 0; k <= (bound) * (bound - 1); k += bound)
                {
                    if (buttonOnTheGrid[i + k] == sign[j])
                    {
                        counter++;
                    }
                    if (counter == bound)
                    {
                        Clear();
                        return sign[j];
                    }
                }
            }
        }
        for (int j = 0; j < 2; j++)
        {
            int counter = 0;
            for (int i = 0; i <= (bound * bound) - 1; i += bound + 1)
            {
                if (buttonOnTheGrid[i] == sign[j])
                {
                    counter++;
                }
                if (counter == bound)
                {
                    Clear();
                    return sign[j];
                }
            }
        }
        for (int j = 0; j < 2; j++)
        {
            int counter = 0;
            for (int i = bound - 1; i <= (bound * bound); i += bound - 1)
            {
                if (buttonOnTheGrid[i] == sign[j])
                {
                    counter++;
                }
                if (counter == bound)
                {
                    Clear();
                    return sign[j];
                }
            }
        }

        if (numberOfClick >= bound * bound)
        {
            Clear();
            return "No one";
        }
        return "";
    }


    private void Clear()
    {
        this.numberOfClick = 0;
    }


}