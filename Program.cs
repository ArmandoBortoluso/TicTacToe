﻿using System;


namespace TicTacToe {

    class MainClass {

        static void Main(string[] args) {

            short[] coord = new short[2];

            string symbol;
            bool victory = false;
            bool draw = false;
            short availablePositions = 9;
            short player = 1;
            bool tryParse = false;
            short pos;

            Board.CleanBoard();
            Console.Write("Player one, select symbol: ");
            symbol = Console.ReadLine();

            Player playerOne = new Player(symbol);

            Console.Write("Player two, select symbol: ");
            symbol = Console.ReadLine();

            Player playerTwo = new Player(symbol);

            do{
                Renderer.Render();
                do{
                Console.Write("Player " + player + " please go, select position:");
                tryParse = short.TryParse(Console.ReadLine(), out pos);
                }while(tryParse == false);

                Position.FindCoordinates(pos, coord);
                
                if(player == 1) {
                    symbol = playerOne.Symbol;

                } else {
                    symbol =playerTwo.Symbol;
                }

                Board.UpdateBoard(coord, symbol);
                victory = WinChecker.CheckWin();

                if(victory) {
                    break;
                }

                availablePositions--;
                if(availablePositions == 0) {
                    draw = true;

                }

                if(player == 1) {
                    player = 2;
                } else {
                    player = 1;
                }

            }while(draw == false);

            if(draw) {
                Console.WriteLine("It was a draw!!!!");
            } else {
                Console.WriteLine("Well done Player " + player + " , you won!!!");
                Renderer.Render();
            }

            

        }

    }
}