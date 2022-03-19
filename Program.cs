using System;


namespace TicTacToe {

    class MainClass {

        static void Main(string[] args) {

            int[] coord = new int[2];

            string symbol;
            bool victory = false;
            bool draw = false;
            int availablePositions = 9;

            Console.Write("Player one, select symbol: ");
            symbol = Console.ReadLine();

            Player playerOne = new Player(symbol);

            Console.Write("Player two, select symbol: ");
            symbol = Console.ReadLine();

            Player playerTwo = new Player(symbol);

            do{

            }while(victory == false || draw == false);


            

 


            

        }

    }
}