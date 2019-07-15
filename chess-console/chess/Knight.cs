using board;

namespace chess
{
    class Knight : Piece
    {
        public Knight(Board br, Color color) : base(br, color)
        {
        }
        public override string ToString()
        {
            return "N";
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

            pos.defineValue(position.line - 1, position.column - 2);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValue(position.line - 2, position.column - 1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValue(position.line - 2, position.column + 1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValue(position.line - 1, position.column + 2);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValue(position.line + 1, position.column + 2);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValue(position.line + 2, position.column + 1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValue(position.line + 2, position.column - 1);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValue(position.line + 1, position.column - 2);
            if (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            return mat;
        }

    }

}