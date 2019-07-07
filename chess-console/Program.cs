using System;
using board;
using chess;


namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                ChessGame game = new ChessGame();
                while (!game.finished)
                {
                    Console.Clear();
                    Screen.printBoard(game.br);

                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = Screen.readChessPosition().toPosition();
                    bool[,] possiblePositions = game.br.piece(origin).possibleMoviments();
                    Console.Clear();
                    Screen.printBoard(game.br, possiblePositions);

                    Console.WriteLine();
                    Console.Write("Destiny: ");
                    Position destiny = Screen.readChessPosition().toPosition();

                    game.performsMoviment(origin, destiny);

                }
                
                Screen.printBoard(game.br);
                

            }catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();


        }
        


    }
}
