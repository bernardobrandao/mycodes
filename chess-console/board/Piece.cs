using System;

namespace board
{
    abstract class Piece
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

        public void increaseNoMoviments()
        {
            noMoviments++;

        }

        public void decreaseNoMoviments()
        {
            noMoviments--;

        }
        public bool existsPossibleMoviments()
        {
            bool[,] mat = possibleMoviments();
            for (int i=0; i<br.lines; i++)
            {
                for (int j=0; j<br.columns; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool canMoveTo(Position pos)
        {
            return possibleMoviments()[pos.line, pos.column];
        }

        public abstract bool[,] possibleMoviments();
        

        

    }
}
