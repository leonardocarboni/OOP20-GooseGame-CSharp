using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP20_GooseGame_Domi
{
    [TestClass]
    public class MemoryTest
    {
        private static readonly int EXPECTED_ERRORS = 5;
        private static readonly int NUM_1 = 1;
        private static readonly int NUM_2 = 2;
        private static readonly int NUM_3 = 3;
        private static readonly int NUM_4 = 4;
        private static readonly int NUM_5 = 5;

        [TestMethod]
        public void CheckErrors()
        {
            ISecretCode secretCode = new SecretCodeImpl();
            int errors = 0;

            List<int> inputCode = new();
            inputCode.Add(NUM_1);
            inputCode.Add(NUM_2);
            inputCode.Add(NUM_3);
            inputCode.Add(NUM_4);
            inputCode.Add(NUM_5);

            List<int> computerCode = new();
            computerCode.Add(NUM_5);
            computerCode.Add(NUM_3);
            computerCode.Add(NUM_2);
            computerCode.Add(NUM_1);
            computerCode.Add(NUM_4);

            secretCode.SetCode(computerCode);
            var code = secretCode.GetCode();

            for (int i = 0; i < code.Count; i++)
            {
                if (!code.ElementAt(i).Equals(inputCode.ElementAt(i)))
                {
                    errors++;
                }
            }

            Assert.AreEqual(EXPECTED_ERRORS, errors);

        }
    }
}