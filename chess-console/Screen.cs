using System;
using board;
using chess;

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
                        printPiece(br.piece(i,j));
                        Console.Write(" ");

                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");

        }

        public static ChessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new ChessPosition(column, line);




        }

        public static void printPiece(Piece piece)
        {
            if (piece.color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }

    }
}
