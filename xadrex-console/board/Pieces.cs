using System;

namespace board
{
    class Pieces
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int noMoviments { get; protected set; }
        public Board br { get; protected set; }

        public Pieces(Position position, Board br, Color color)
        {
            this.position = position;
            this.br = br;
            this.color = color;
            this.noMoviments = 0;
        }
    }
}
