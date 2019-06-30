using board;

namespace chess
{
    class King : Piece
    {
        public King(Board br, Color color) : base(br, color){
        }
        public override string ToString(){
            return "K";
        }

    
    
    }
}
