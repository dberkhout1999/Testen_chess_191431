using Chess.Business;
using NUnit.Framework;
using System;

namespace TestChess
{
    public class TestPerformance
    {
        private Board Board { get; set; }

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestStartUpPerformance() // checked de performance van het aanmaken van het spel
        {
            var voor = DateTime.Now;
            Board = new Board();
            Board.StartNewGame();

            var na = DateTime.Now;
            var duur = (na - voor).Milliseconds;
            Assert.IsTrue(duur < 1000);
        }

        [Test]
        public void TestMovePiecePerformance() // checked of de performance van een beurt
        {
            Board = new Board();
            Board.StartNewGame();
            
            var voor = DateTime.Now;
            Board.MovePiece("f2", "f4"); // wpawn
            var na = DateTime.Now;
            var duur = (na - voor).Milliseconds;
            Assert.IsTrue(duur < 100);
        }


    }
}