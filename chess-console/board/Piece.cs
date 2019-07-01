using System;

namespace board
{
    class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int noMoviments { get; protected set; }
        public Board br { get; protected set; }

        public Piece(Board br, Color color)
        {
            this.position = null;
            this.br = br;
            this.color = color;
            this.noMoviments = 0;
        }
    }
}
