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
                for (int j=0; j<br.columns; j++)
                {
                    if (br.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(br.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }

        }


    }
}
