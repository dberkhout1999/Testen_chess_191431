using Chess.Business;
using NUnit.Framework;
using System;

namespace TestChess
{
    public class TestSpecialeRegels
    {
        private Board Board { get; set; }

        [SetUp]
        public void Setup()
        {
            Board = new Board();
            Board.StartNewGame();
        }

        [Test]
        public void TestRokade() // checked of rokade werkt
        {

            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));


            Assert.IsTrue(Board.MovePiece("f2", "f4")); // wpawn
            Assert.IsTrue(Board.MovePiece("f7", "f5")); // bpawn

            Assert.IsTrue(Board.MovePiece("f1", "a6")); // wbishop
            Assert.IsTrue(Board.MovePiece("h7", "h5")); // bpawn

            Assert.IsTrue(Board.MovePiece("g1", "f3")); // whorse
            Assert.IsTrue(Board.MovePiece("g8", "f6")); // bhorse

            Assert.IsTrue(Board.MovePiece("e1", "g1")); // wking


            var whiteRook = Board.GetField('f', 1).Piece;
            Assert.AreEqual(PieceType.Rook, whiteRook.Type);

            var whiteKing = Board.GetField('g', 1).Piece;
            Assert.AreEqual(PieceType.King, whiteKing.Type);
        }

        [Test]
        public void PawnToQueen() // cheked of de pawn gepromoveerd kan worden naar een queen
        {
            Assert.IsFalse(Board.IsChecked(Colour.Black));
            Assert.IsFalse(Board.IsChecked(Colour.White));

            Assert.IsTrue(Board.MovePiece("f2", "f4")); // wpawn
            Assert.IsTrue(Board.MovePiece("c7", "c5")); // bpawn

            Assert.IsTrue(Board.MovePiece("b1", "a3")); // whorse
            Assert.IsTrue(Board.MovePiece("g8", "h6")); // bhorse

            Assert.IsTrue(Board.MovePiece("f4", "f5")); // wpawn
            Assert.IsTrue(Board.MovePiece("c5", "c4")); // bpawn

            Assert.IsTrue(Board.MovePiece("f5", "f6")); // wpawn
            Assert.IsTrue(Board.MovePiece("c4", "c3")); // bpawn

            Assert.IsTrue(Board.MovePiece("f6", "g7")); // wpawn
            Assert.IsTrue(Board.MovePiece("c3", "b2")); // bpawn

            var WhitePawn = Board.GetField('g', 7).Piece; // checked dat hij niet te vroeg een queen word
            Assert.AreEqual(PieceType.Pawn, WhitePawn.Type); 

            var BlackPawn = Board.GetField('b', 2).Piece;// checked dat hij niet te vroeg een queen word
            Assert.AreEqual(PieceType.Pawn, BlackPawn.Type);

            Assert.IsTrue(Board.MovePiece("g7", "g8")); // wpawn en nu wQueen
            Assert.IsTrue(Board.MovePiece("b2", "b1")); // bpawn en nu bQueen
            

            var whitequeen = Board.GetField('g', 8).Piece;
            Assert.AreEqual(PieceType.Queen, whitequeen.Type);

            var blackqueen = Board.GetField('b', 1).Piece;
            Assert.AreEqual(PieceType.Queen, blackqueen.Type);

        }


    }
}