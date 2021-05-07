using System;
using System.Collections.Generic;

namespace OOP20_GooseGame_Domi
{
    public interface ISecretCode
    {
        /// <summary>
        /// Generates a random Secret Code.
        /// </summary>
        /// <returns></returns>
        void GenerateSecretCode();

        /// <summary>
        /// Confront secretCode with user input.
        /// </summary>
        /// <param name="inputCode"></param>
        /// <returns></returns>
        int CheckCode(List<int> inputCode);

        /// <summary>
        /// Code as a string.
        /// </summary>
        /// <returns></returns>
        string GetCode();

        /// <summary>
        /// Is use for Testing.
        /// Creates a list of hypothetical computer choice.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        void SetCode(List<int> code);
    }
}