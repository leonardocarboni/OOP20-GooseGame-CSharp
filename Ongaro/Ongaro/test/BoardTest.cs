using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ongaro.board;
using Ongaro.box;
using System.Collections.Generic;

namespace Ongaro.test
{
    class BoardTest
    {
        public void BoardTest1()
        {
            IBoard board = new Board();
            List<Box> listExpected = new List<Box>();
            listExpected.Add(Box.START);
            listExpected.Add(Box.END);
            board.Size = 2;
            CollectionAssert.AreEqual(listExpected, board.GenerateBoard());
        }

        [TestMethod]
        public void BoardTest2()
        {
            IBoard board = new Board();
            List<Box> listExpected = new List<Box>();
            listExpected.Add(Box.START);
            listExpected.Add(Box.NORMAL);
            listExpected.Add(Box.NORMAL);
            listExpected.Add(Box.NORMAL);
            listExpected.Add(Box.NORMAL);
            listExpected.Add(Box.TICTACTOE);
            listExpected.Add(Box.NORMAL);
            listExpected.Add(Box.NORMAL);
            listExpected.Add(Box.END);
            board.Size = 9;
            CollectionAssert.AreEqual(listExpected, board.GenerateBoard());
        }

        [TestMethod]
        public void BoardTest3()
        {
            IBoard board = new Board();
            Assert.ThrowsException<System.Exception>(() => board.Size = 1);
        }
    }
}
