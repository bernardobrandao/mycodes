﻿using board;

namespace chess
{
    class Rook : Piece
    {
        public Rook(Board br, Color color) : base(br, color)
        {
        }

        public override string ToString()
        {
            return "R";
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
            //north
            pos.defineValue(position.line - 1, position.column);
            while (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (br.piece(pos) != null && br.piece(pos).color != color)
                {
                    break;
                }
                pos.line = pos.line - 1;
            }
            //south
            pos.defineValue(position.line + 1, position.column);
            while (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (br.piece(pos) != null && br.piece(pos).color != color)
                {
                    break;
                }
                pos.line = pos.line + 1;
            }
            //east
            pos.defineValue(position.line, position.column + 1);
            while (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (br.piece(pos) != null && br.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column + 1;
            }
            //west
            pos.defineValue(position.line, position.column - 1);
            while (br.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (br.piece(pos) != null && br.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column - 1;
            }



            return mat;
        }
    }
}