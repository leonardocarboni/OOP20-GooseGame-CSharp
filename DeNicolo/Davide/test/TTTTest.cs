
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TTTTest
{
    [TestClass]
    public class TTTTest
    {
        private static readonly int BOUND = 3;
        private List<String> listButtonGrid = new List<string>();
        private readonly List<String> sign = new List<string>();
        private readonly int maxRange = 9;
        [TestMethod]
        public void TestTTT()
        {
            using (var sw = new StringWriter())
            {
                sign.Insert(0, "O");
                sign.Insert(1, "X");
                for (int i = 0; i <= maxRange; i++)
                {
                    listButtonGrid.Insert(i, "X");
                }
                for (int i = 3; i <= maxRange; i++)
                {
                    listButtonGrid.Insert(i, "-");
                }
                /*
                 * Vince la X orizzontale
                 */
                for (int i = 0; i <= (BOUND) * (BOUND - 1); i += BOUND)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int counter = 0;
                        for (int k = 0; k < BOUND; k++)
                        {
                            if (listButtonGrid[i + k] == (sign[j]))
                            {
                                counter++;
                            }
                            if (counter == BOUND)
                            {
                                Assert.AreEqual(sign[j], "X"); //vince la X
                            }
                        }
                    }
                }

                //vince X verticale
                listButtonGrid.Insert(0, "X");
                listButtonGrid.Insert(3, "X");
                listButtonGrid.Insert(6, "X");

                for (int i = 0; i < BOUND; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int counter = 0;
                        for (int k = 0; k <= (BOUND) * (BOUND - 1); k += BOUND)
                        {
                            if (listButtonGrid[i + k] == (sign[j]))
                            {
                                counter++;
                            }
                            if (counter == BOUND)
                            {
                                Assert.AreEqual(sign[j], "X");
                            }
                        }
                    }
                }
                //vince O obliqua principale
                listButtonGrid.Insert(0, "O");
                listButtonGrid.Insert(4, "O");
                listButtonGrid.Insert(8, "O");

                for (int j = 0; j < 2; j++)
                {
                    int counter = 0;
                    for (int i = 0; i < BOUND * BOUND; i += BOUND + 1)
                    {
                        if (listButtonGrid[i] == sign[j])
                        {
                            counter++;
                        }
                        if (counter == BOUND)
                        {
                            Assert.AreEqual(sign[j], "O");
                        }
                    }
                }


                //vince O obliqua secondaria
                listButtonGrid.Insert(2, "O");
                listButtonGrid.Insert(4, "O");
                listButtonGrid.Insert(6, "O");

                for (int j = 0; j < 2; j++)
                {
                    int counter = 0;
                    for (int i = BOUND - 1; i < BOUND * BOUND; i += BOUND - 1)
                    {
                        if (listButtonGrid[i] == sign[j])
                        {
                            counter++;
                        }
                        if (counter == BOUND)
                        {
                            Assert.AreEqual(sign[j], "O");
                        }
                    }
                }
            }
        }
    }
}
