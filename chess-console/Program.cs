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
                    try
                    {
                        Console.Clear();
                        Screen.printGame(game);



                        Console.WriteLine();
                        Console.Write("Origin: ");
                        Position origin = Screen.readChessPosition().toPosition();
                        game.validateOriginPosition(origin);

                        bool[,] possiblePositions = game.br.piece(origin).possibleMoviments();

                        Console.Clear();
                        Screen.printBoard(game.br, possiblePositions);

                        Console.WriteLine();
                        Console.Write("Destiny: ");
                        Position destiny = Screen.readChessPosition().toPosition();
                        game.validateDestinyPosition(origin, destiny);

                        game.makeaMove(origin, destiny);
                    } catch (BoardException e)
                    
{
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Please try again by pressing enter on the keyboard");
                        Console.ReadLine();
                    }

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
