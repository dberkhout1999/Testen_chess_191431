using Chess.Business;
using NUnit.Framework;
using System;

namespace TestChess
{
    public class TestStandaardRegels
    {
        private Board Board { get; set; }

        [SetUp]
        public void Setup()
        {
            Board = new Board();
            Board.StartNewGame();
        }

        [Test]
        public void TestAlleBasicMovement() // checked of de queen alle kanten op mag
        {
            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));

            Assert.IsTrue(Board.MovePiece("d2", "d4")); // wpawn
            Assert.IsTrue(Board.MovePiece("g8", "h6")); // bhorse

            Assert.IsTrue(Board.MovePiece("d1", "d3")); // wqueen
            Assert.IsTrue(Board.MovePiece("h6", "g8")); // bhorse

            Assert.IsTrue(Board.MovePiece("d3", "a3")); // wqueen
            Assert.IsTrue(Board.MovePiece("g8", "h6")); // bhorse

            Assert.IsTrue(Board.MovePiece("a3", "d6")); // wqueen
            Assert.IsTrue(Board.MovePiece("h6", "g8")); // bhorse

            Assert.IsTrue(Board.MovePiece("d6", "g3")); // wqueen
            Assert.IsTrue(Board.MovePiece("g8", "h6")); // bhorse

            Assert.IsTrue(Board.MovePiece("g3", "g6")); // wqueen
            Assert.IsTrue(Board.MovePiece("h6", "g8")); // bhorse

            Assert.IsTrue(Board.MovePiece("g6", "g3")); // wqueen

        }

        [Test]
        public void TestHorseJump() // checked of het paard over pieces heen mag en of de sprongen kloppen
        {
            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));

            Assert.IsTrue(Board.MovePiece("g1", "f3")); // whorse
            Assert.IsTrue(Board.MovePiece("g8", "f6")); // bhorse

            Assert.IsTrue(Board.MovePiece("b1", "c3")); // whorse
            Assert.IsTrue(Board.MovePiece("b8", "c6")); // bhorse
            
        }

        
        [Test]
        public void TestPawnFirstMove() // checked of een pawn twee stappen mag zetten bij zijn eerste stap
        {
            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));

            Assert.IsTrue(Board.MovePiece("d2", "d4")); // wpawn
            Assert.IsTrue(Board.MovePiece("d7", "d5")); // bpawn

        }

        [Test]
        public void TestKingAntiCheck() // checked of de king zichzelf schaak mag zetten
        {
            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));

            Assert.IsTrue(Board.MovePiece("e2", "e4")); // wpawn
            Assert.IsTrue(Board.MovePiece("h7", "h5")); // bpawn

            Assert.IsTrue(Board.MovePiece("e1", "e2")); // wking
            Assert.IsTrue(Board.MovePiece("h8", "h6")); // brook

            Assert.IsTrue(Board.MovePiece("e2", "e3")); // wking
            Assert.IsTrue(Board.MovePiece("h6", "f6")); // brook.

            Assert.IsFalse(Board.MovePiece("e3", "f3")); // wking
         }



    }
}