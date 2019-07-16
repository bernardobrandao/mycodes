using board;

namespace chess
{
    class Pawn : Piece
    {
        private ChessGame game;

        public Pawn(Board br, Color color, ChessGame game) : base(br, color)
        {
            this.game = game;
        }
        public override string ToString()
        {
            return "P";
        }

        private bool existsEnemy(Position pos)
        {
            Piece p = br.piece(pos);
            return p != null && p.color != color;
        }

        private bool free(Position pos)
        {
            return br.piece(pos) == null;
        }


        public override bool[,] possibleMoviments()
        {
            bool[,] mat = new bool[br.lines, br.columns];
            Position pos = new Position(0, 0);

            if (color == Color.White)
            {
                pos.defineValue(position.line - 1, position.column);
                if (br.validPosition(pos) && free(pos))
                {
                    mat[pos.line, pos.column] = true;
                }

                pos.defineValue(position.line - 2, position.column);
                if (br.validPosition(pos) && free(pos) && noMoviments == 0)
                {
                    mat[pos.line, pos.column] = true;
                }

                pos.defineValue(position.line - 1, position.column - 1);
                if (br.validPosition(pos) && existsEnemy(pos))
                {
                    mat[pos.line, pos.column] = true;
                }

                pos.defineValue(position.line - 1, position.column + 1);
                if (br.validPosition(pos) && existsEnemy(pos))
                {
                    mat[pos.line, pos.column] = true;
                }

                //Special moviment En Passant
                if(position.line == 3)
                {
                    Position left = new Position(position.line, position.column - 1);
                    if(br.validPosition(left) && existsEnemy(left) && br.piece(left) == game.vulnerableEnPassant)
                    {
                        mat[left.line - 1, left.column] = true;

                    }
                    Position right = new Position(position.line, position.column + 1);
                    if (br.validPosition(right) && existsEnemy(right) && br.piece(right) == game.vulnerableEnPassant)
                    {
                        mat[right.line - 1, right.column] = true;

                    }
                }


            }
            else
            {
                pos.defineValue(position.line + 1, position.column);
                if (br.validPosition(pos) && free(pos))
                {
                    mat[pos.line, pos.column] = true;
                }

                pos.defineValue(position.line + 2, position.column);
                if (br.validPosition(pos) && free(pos) && noMoviments == 0)
                {
                    mat[pos.line, pos.column] = true;
                }

                pos.defineValue(position.line + 1, position.column - 1);
                if (br.validPosition(pos) && existsEnemy(pos))
                {
                    mat[pos.line, pos.column] = true;
                }

                pos.defineValue(position.line + 1, position.column + 1);
                if (br.validPosition(pos) && existsEnemy(pos))
                {
                    mat[pos.line, pos.column] = true;
                }
                //Special moviment En Passant
                if (position.line == 4)
                {
                    Position left = new Position(position.line, position.column - 1);
                    if (br.validPosition(left) && existsEnemy(left) && br.piece(left) == game.vulnerableEnPassant)
                    {
                        mat[left.line + 1, left.column] = true;

                    }
                    Position right = new Position(position.line, position.column + 1);
                    if (br.validPosition(right) && existsEnemy(right) && br.piece(right) == game.vulnerableEnPassant)
                    {
                        mat[right.line + 1, right.column] = true;

                    }
                }


            }

            return mat;
        }
    }
}