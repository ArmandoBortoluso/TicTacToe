namespace TicTacToe {
    class Board {

        private static string[,] board = new string[3,3];

        public static void CleanBoard() {
            for(int x = 0; x < 3; x++) {
                for(int y = 0; y < 3; y++) {

                    board[x,y] = " ";
                }

            }
        }

        public static void UpdateBoard(short[] coord, string symbol) {

            short x = coord[0];
            short y = coord[1];

            board[x,y] = symbol;
        }

        public static string CheckState(int x, int y) {

            return(board[x,y]);


        }
        public static string CheckState(short[] coord) {
            
            short x, y;
            x = coord[0];
            y = coord[1];
            return(board[x,y]);


        }




    }
}