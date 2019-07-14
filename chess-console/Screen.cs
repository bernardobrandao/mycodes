using System;
using System.Collections.Generic;
using board;
using chess;

namespace chess_console
{
    class Screen
    {
        public static void printGame(ChessGame game)
        {
            printBoard(game.br);
            Console.WriteLine();
            printCapturedPieces(game);
            Console.WriteLine();
            Console.WriteLine("Shift: " + game.shift);
            Console.WriteLine("Waiting a move: " + game.currentPlayer);
            if (game.check)
            {
                Console.Write("You are in check mate!");
            }
        }

        public static void printCapturedPieces(ChessGame game)
        {
            Console.WriteLine();
            Console.WriteLine("Captured Pieces: ");
            Console.Write("White: ");
            printSet(game.capturedPiece(Color.White));
            Console.WriteLine();
            Console.Write("Black: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            printSet(game.capturedPiece(Color.Black));
            Console.ForegroundColor = aux;
            Console.WriteLine();

        }

        public static void printSet(HashSet<Piece> set)
        {
            Console.Write("[");
            foreach (Piece x in set)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static void printBoard(Board br)
        {
            for (int i = 0; i < br.lines; i++)
            {
                
                Console.Write(8 - i + " ");
                for (int j = 0; j < br.columns; j++)
                {
                    printPiece(br.piece(i, j));

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");

        }

        public static void printBoard(Board br, bool[,] possiblePositions)
        {
            ConsoleColor originalBackground = Console.BackgroundColor;
            ConsoleColor alteredBackground = ConsoleColor.DarkGray;
            for (int i = 0; i < br.lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < br.columns; j++)
                {
                    if (possiblePositions[i, j])
                    {
                        Console.BackgroundColor = alteredBackground;
                    }
                    else
                    {
                        Console.BackgroundColor = originalBackground;
                    }
                    printPiece(br.piece(i, j));
                    Console.BackgroundColor = originalBackground;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = originalBackground;

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
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
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
                Console.Write(" ");
            }



        }

    }
}
