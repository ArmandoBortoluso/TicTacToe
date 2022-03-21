namespace TicTacToe {
    class Renderer {

        public static async void Render() {

            int[] coord = new int[2];
            string symbol;

            for(int i = 0; i < 3; i++) {

                coord[0] = i;

                for(int j = 0; j < 3; j++) {

                    coord[1] = j;

                    symbol = Board.CheckState(coord);

                    Console.Write(symbol);
                    
                    if(j != 2) {
                        Console.Write("|");
                    }

                }
                Console.WriteLine("");
            }


        }
        



    }
}