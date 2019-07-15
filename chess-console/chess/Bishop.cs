using board;

namespace chess
{
    class Bishop : Piece
    {
        public Bishop(Board br, Color color) : base(br, color)
        {
        }
        public override string ToString()
        {
            return "B";
        }

        private bool canMove(Position pos)
        {
            Piece p = br.piece(pos);
            return p == null || p.color != color;
        }

        public override bool[,] possibleMoviments()
        {
            bool[,] mat = new bool[br.lines, br.columns];
            Position pos = new Position(0, 0);

            pos.defineValue(position.line - 1, position.column - 1);
            while (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (br.piece(pos) != null && br.piece(pos).color != color)
                {
                    break;
                }
                pos.defineValue(pos.line - 1, pos.column - 1);
            }


            pos.defineValue(position.line - 1, position.column + 1);
            while (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (br.piece(pos) != null && br.piece(pos).color != color)
                {
                    break;
                }
                pos.defineValue(pos.line - 1, pos.column + 1);
            }

            pos.defineValue(position.line + 1, position.column + 1);
            while (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (br.piece(pos) != null && br.piece(pos).color != color)
                {
                    break;
                }
                pos.defineValue(pos.line + 1, pos.column + 1);
            }

            pos.defineValue(position.line + 1, position.column - 1);
            while (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (br.piece(pos) != null && br.piece(pos).color != color)
                {
                    break;
                }
                pos.defineValue(pos.line + 1, pos.column - 1);
            }

            return mat;
        }


    }
}