using System;
using board;

namespace chess
{
    class ChessGame
    {
        public Board br { get; private set; }
        private int shift;
        private Color currentPlayer;
        public bool finished { get; private set; }

        public ChessGame()
        {
            br = new Board(8, 8);
            shift = 1;
            currentPlayer = Color.White;
            finished = false;
            putPieces();
        }

        public void performsMoviment(Position origin, Position destiny)
        {
            Piece p = br.throwPiece(origin);
            p.increaseNoMoviments();
            Piece capturedPiece = br.throwPiece(destiny);
            br.putPiece(p, destiny);


        }

        private void putPieces()
        {
            br.putPiece(new Rook(br, Color.White), new ChessPosition('a', 1).toPosition());
            br.putPiece(new Rook(br, Color.White), new ChessPosition('h', 1).toPosition());
            br.putPiece(new King(br, Color.White), new ChessPosition('e', 1).toPosition());
            br.putPiece(new Rook(br, Color.Black), new ChessPosition('a', 8).toPosition());
            br.putPiece(new Rook(br, Color.Black), new ChessPosition('h', 8).toPosition());
            br.putPiece(new King(br, Color.Black), new ChessPosition('e', 8).toPosition());
        }

    }
}
