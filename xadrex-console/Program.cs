﻿using System;
using board;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board br = new Board(8, 8);
            Screen.printBoard(br);

        }
    }
}
