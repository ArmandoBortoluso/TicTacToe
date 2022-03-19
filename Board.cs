namespace TicTacToe {
    class Board {

        private static string[,] board = new string[3,3];

        public static void CleanBoard(string[,] board) {
            for(int x = 0; x < 3; x++) {
                for(int y = 0; y < 3; y++) {

                    board[x,y] = "";
                }

            }
        }

        public static void UpdateBoard(int[] coord, string symbol) {
            int x, y;

            x = coord[0];
            y = coord[1];

            board[x,y] = symbol;
        }

        public static string CheckState(int[] coord) {

            int x,y;

            x = coord[0];
            y = coord[1];

            return(board[x,y]);


        }




    }
}