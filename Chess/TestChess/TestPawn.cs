using Chess.Business;
using NUnit.Framework;
using System;

namespace TestChess
{
    public class TestPawn
    {
        private Board Board { get; set; }

        [SetUp]
        public void Setup()
        {
            Board = new Board();
            Board.StartNewGame();
        }

        [Test]
        public void TestStartPosition()
        {
            var pawn = Board.GetField('e', 2).Piece;
            
            Assert.AreEqual(2, pawn.CanMoveTo().Count);
        }

        [Test]
        public void TestAttack()
        {
            var pawn = Board.GetField('e', 2).Piece;

            pawn.PlaceOn(Board.GetField('e', 6));
            Assert.AreEqual(2, pawn.CanMoveTo().Count);
        }

        [Test]
        public void TestStandardMove()
        {
            var pawn = Board.GetField('e', 2).Piece;

            pawn.PlaceOn(Board.GetField('e', 4));
            Assert.AreEqual(1, pawn.CanMoveTo().Count);
        }
    }
}