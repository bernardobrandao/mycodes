using System;
using board;

namespace chess_console
{
    class Screen
    {
        public static void printBoard(Board br)
        {
            for (int i=0; i<br.lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j=0; j<br.columns; j++)
                {
                    if (br.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(br.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");

        }
        public static void printPiece(Piece piece)
        {
            if (piece.color == Color.White)
            {
                Console.WriteLine(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

    }
}
