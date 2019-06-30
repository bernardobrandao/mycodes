using System;
using board;
using chess;


namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board br = new Board(8, 8);
            br.putPiece(new Rook(br, Color.Black), new Position(0, 0));
            br.putPiece(new Rook(br, Color.Black), new Position(1, 3));
            br.putPiece(new King(br, Color.Black), new Position(2, 4));



            Screen.printBoard(br);
            Console.ReadLine();

        }

        


    }
}
