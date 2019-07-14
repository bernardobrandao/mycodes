using System;
using board;
using System.Collections.Generic;

namespace chess
{
    class ChessGame
    {
        public Board br { get; private set; }
        public int shift { get; private set; }
        public Color currentPlayer { get; private set; }
        public bool finished { get; private set; }
        private HashSet<Piece> pieces;
        private HashSet<Piece> captured;
        public bool check { get; private set; }

        public ChessGame()
        {
            br = new Board(8, 8);
            shift = 1;
            currentPlayer = Color.White;
            finished = false;
            pieces = new HashSet<Piece>();
            captured = new HashSet<Piece>();
            putPieces();
        }

        public Piece performsMoviment(Position origin, Position destiny)
        {
            Piece p = br.throwPiece(origin);
            p.increaseNoMoviments();
            Piece capturedPiece = br.throwPiece(destiny);
            br.putPiece(p, destiny);
            if (capturedPiece != null)
            {
                captured.Add(capturedPiece);
            }
            return capturedPiece;
        }
        public void undoTheMove(Position origin, Position destiny, Piece capturedPiece)
        {
            Piece p = br.throwPiece(destiny);
            p.decreaseNoMoviments();
            if (capturedPiece != null)
            {
                br.putPiece(capturedPiece, destiny);
                captured.Remove(capturedPiece);
            }
            br.putPiece(p, origin);

        }



        public void makeaMove(Position origin, Position destiny)
        {
            Piece capturedPiece = performsMoviment(origin, destiny);
            if (checkMate(currentPlayer))
            {
                undoTheMove(origin, destiny, capturedPiece);
                throw new BoardException("You can not put yourself in checkmate!");
            }
            if (checkMate(adversary(currentPlayer)))
            {
                check = true;
            }
            else
            {
                check = false;
            }

            shift++;
            changePlayer();
        }
        public void validateOriginPosition(Position pos)
        {
            if (br.piece(pos) == null)
            {
                throw new BoardException("There is no piece in the chosen origin position");
            }
            if (currentPlayer != br.piece(pos).color)
            {
                throw new BoardException("The chosen origin piece is not yours");
            }
            if (!br.piece(pos).existsPossibleMoviments())
            {
                throw new BoardException("There are no possible moves for the chosen origin piece");
            }

        }

        public void validateDestinyPosition(Position origin, Position destiny)
        {
            if (!br.piece(origin).canMoveTo(destiny))
            {
                throw new BoardException("Invalid destiny position");
            }

        }


        private void changePlayer()
        {
            if (currentPlayer == Color.Black)
            {
                currentPlayer = Color.White;
            } else
            {
                currentPlayer = Color.Black;
            }
        }

        public HashSet<Piece> capturedPiece(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece x in captured)
            {
                if (x.color == color)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Piece> piecesOnGame(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece x in pieces)
            {
                if (x.color == color)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(capturedPiece(color));
            return aux;
        }

        private Color adversary(Color color)
        {
            if (color == Color.Black)
            {
                return Color.White;
            }
            else
            {
                return Color.Black;
            }


        } 

        private Piece king(Color color)
        {
            foreach (Piece x in piecesOnGame(color))
            {
                if (x is King)
                {
                    return x;
                }
            }
            return null;
        }

        public bool checkMate(Color color)
        {
            Piece K = king(color);
            if (K == null)
            {
                throw new BoardException("There is not have King " + color + "on chess board!");
            }

            foreach (Piece x in piecesOnGame(adversary(color)))
            {
                bool[,] mat = x.possibleMoviments();
                if (mat [K.position.line, K.position.column])
                {
                    return true;
                }
            }
            return false;
        }

        public void putNewPiece(char column, int line, Piece piece)
        {
            br.putPiece(piece, new ChessPosition(column, line).toPosition());
            pieces.Add(piece);
        }

        private void putPieces()
        {
            putNewPiece('a', 1, new Rook(br, Color.White));
            putNewPiece('h', 1, new Rook(br, Color.White));
            putNewPiece('e', 1, new King(br, Color.White));
            putNewPiece('a', 8, new Rook(br, Color.Black));
            putNewPiece('h', 8, new Rook(br, Color.Black));
            putNewPiece('e', 8, new King(br, Color.Black));
            
        }

    }
}
