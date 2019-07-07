using board;

namespace chess
{
    class King : Piece
    {
        public King(Board br, Color color) : base(br, color) {
        }
        public override string ToString() {
            return "K";
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

            return mat;

        }


    }
}
