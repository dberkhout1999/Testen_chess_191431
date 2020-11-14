using Chess.Business;
using NUnit.Framework;
using System;

namespace TestChess
{
    public class TestSlaanRegels
    {
        private Board Board { get; set; }

        [SetUp]
        public void Setup()
        {
            Board = new Board();
            Board.StartNewGame();
        }

        [Test]
        public void TestEnemyHit() // checked je een enemy piece mag slaan
        {
            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));

            Assert.IsTrue(Board.MovePiece("d2", "d4")); // wpawn
            Assert.IsTrue(Board.MovePiece("e7", "e5")); // bpawn

            Assert.IsTrue(Board.MovePiece("d4", "e5")); // wpawn

        }

        [Test]
        public void TestFriendlyHit() // checked je niet een friendly piece mag slaan
        {
            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));

            Assert.IsFalse(Board.MovePiece("a1", "a2")); // wrook

            
        }

        
        [Test]
        public void TestPawnDiagonalHit() // checked of een pawn schuin mag slaan
        {
            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));

            Assert.IsTrue(Board.MovePiece("d2", "d4")); // wpawn
            Assert.IsTrue(Board.MovePiece("e7", "e5")); // bpawn

            Assert.IsTrue(Board.MovePiece("d4", "e5")); // wpawn
        }

        [Test]
        public void TestPieceDisapearsOnHit() // of er neen piece achter blijft nadat hij geslagen is
        {
            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));

            Assert.IsTrue(Board.MovePiece("d2", "d4")); // wpawn
            Assert.IsTrue(Board.MovePiece("e7", "e5")); // bpawn

            Assert.IsTrue(Board.MovePiece("d4", "e5")); // wpawn
            Assert.IsTrue(Board.MovePiece("h7", "h5")); // bpawn

            Assert.IsTrue(Board.MovePiece("e5", "e6")); // wpawn
            Assert.IsFalse(Board.MovePiece("e5", "e4")); // wpawn
        }

    }
}