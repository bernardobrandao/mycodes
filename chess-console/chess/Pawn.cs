using board;

namespace chess
{
    class Pawn : Piece
    {
        public Pawn(Board br, Color color) : base(br, color)
        {
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
            }

            return mat;
        }
    }
}