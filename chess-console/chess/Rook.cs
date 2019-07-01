using board;

namespace chess
{
    class Rook : Piece
    {
        public Rook (Board br, Color color) : base(br, color)
        {
        }
        public override string ToString()
        {
            return "R";
        }



    }
}