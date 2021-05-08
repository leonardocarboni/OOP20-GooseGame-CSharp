using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ongaro.board;
using Ongaro.box;
using Ongaro.exception;
using System.Collections.Generic;

namespace Ongaro.test
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void CreationSmallestBoard()
        {
            IBoard board = new Board();
            List<Box> listExpected = new List<Box>();
            listExpected.Add(Box.START);
            listExpected.Add(Box.END);
            board.Size = 2;
            CollectionAssert.AreEqual(listExpected, board.GenerateBoard());
        }

        [TestMethod]
        public void CreateBoard()
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
        public void LaunchException()
        {
            IBoard board = new Board();
            _ = Assert.ThrowsException<IllegalArgumentException>(() => board.Size = 1);
        }
    }
}
