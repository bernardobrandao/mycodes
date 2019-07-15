using board;

namespace chess
{
    class King : Piece
    {
        private ChessGame game;

        public King(Board br, Color color, ChessGame game) : base(br, color)
        {
            this.game = game;
        }
        public override string ToString() {
            return "K";
        }

        private bool canMove(Position pos)
        {
            Piece p = br.piece(pos);
            return p == null || p.color != color;
        }
        private bool rookTestForCastling(Position pos)
        {
            Piece p = br.piece(pos);
            return p != null && p is Rook && p.color == color && p.noMoviments == 0;
        }


        public override bool[,] possibleMoviments()
        {
            bool[,] mat = new bool[br.lines, br.columns];
            Position pos = new Position(0, 0);
            //n
            pos.defineValue(position.line - 1, position.column);
            if(br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            //ne
            pos.defineValue(position.line - 1, position.column +1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            //e
            pos.defineValue(position.line, position.column + 1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            //se
            pos.defineValue(position.line = 1, position.column + 1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            //s
            pos.defineValue(position.line +1, position.column);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            //sw
            pos.defineValue(position.line + 1, position.column - 1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            //w
            pos.defineValue(position.line, position.column - 1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            //nw
            pos.defineValue(position.line - 1, position.column - 1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //special move Castling

            if(noMoviments == 0 && !game.check)
            {
                Position posR1 = new Position(position.line, position.column + 3);
                if (rookTestForCastling(posR1))
                {
                    Position p1 = new Position(position.line, position.column + 1);
                    Position p2 = new Position(position.line, position.column + 1);
                    if (br.piece(p1) == null && br.piece(p2) == null)
                    {
                        mat[position.line, position.column + 2] = true;
                    }
                }
            }

            //special move Big Castling
            if (noMoviments == 0 && !game.check)
            {
                Position posR2 = new Position(position.line, position.column - 4);
                if (rookTestForCastling(posR2))
                {
                    Position p1 = new Position(position.line, position.column - 1);
                    Position p2 = new Position(position.line, position.column - 2);
                    Position p3 = new Position(position.line, position.column - 3);
                    if (br.piece(p1) == null && br.piece(p2) == null && br.piece(p3) == null)
                    {
                        mat[position.line, position.column - 2] = true;
                    }
                }
            }

            return mat;

        }


    }
}
