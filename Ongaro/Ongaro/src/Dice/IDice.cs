using System;
using System.Collections.Generic;
using System.Text;

namespace Ongaro.dice
{
    interface IDice
    {
        /// <summary>
        /// Get value of roll dice. Min 1 - Max 6
        /// </summary>
        /// <returns> Value of the dice roll. </returns> 
        int roll();
    }
}
