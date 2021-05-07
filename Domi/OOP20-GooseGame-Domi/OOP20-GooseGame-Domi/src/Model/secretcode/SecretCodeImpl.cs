using System;
using System.Collections.Generic;

namespace OOP20_GooseGame_Domi
{
    public class SecretCodeImpl : ISecretCode
    {
        private static readonly int SIZE = 5;
        private static readonly int MAX_VALUE_CODE = 9;
        private static readonly int MIN_VALUE_CODE = 1;

        private readonly Random random = new Random();
        private List<int> secretCode = new();


        public int CheckCode(List<int> inputCode)
        {
            int errors = 0;

            if (inputCode.Count < SIZE)
            {
                errors = SIZE;
            }
            else
            {
                for (int i = 0; i < SIZE; i++)
                {

                    if (!secretCode.ToArray()[i].Equals(inputCode.ToArray()[i]))
                    {
                        errors++;
                    }
                }
            }

            return errors;
        }

        public void GenerateSecretCode()
        {
            for (int i = 0; i < SIZE; i++)
            {
                secretCode.Add(random.Next(MAX_VALUE_CODE) + MIN_VALUE_CODE);
            }
        }

        public string GetCode()
        {
            return secretCode.ToString();
        }

        public void SetCode(List<int> code)
        {
            secretCode = code;
        }
    }
}