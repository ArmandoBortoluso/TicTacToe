namespace TicTacToe {
    class WinChecker {

        public static bool CheckWin() {

            bool win = false;

            //Check horizontals

            for(int x = 0; x < 3; x++) {

                if(
                    String.Equals(Board.CheckState(x, 0), Board.CheckState(x,1)) &&
                    String.Equals(Board.CheckState(x, 0), Board.CheckState(x,2)) &&
                    !String.Equals(Board.CheckState(x,0), " ")
                ) {
                    
                    win = true;
                    return win;
                }
            }

            
            //Check Verticals            
            for(int y = 0; y < 3; y++) {

                if(
                    String.Equals(Board.CheckState(0, y), Board.CheckState(1,y)) &&
                    String.Equals(Board.CheckState(0, y), Board.CheckState(2,y)) &&
                    !String.Equals(Board.CheckState(0,y), " ")
                ) {
  
                    win = true;
                    return win;
                }


            }

            //Check diagonals

            if(
                String.Equals(Board.CheckState(0, 0), Board.CheckState(1,1)) &&
                String.Equals(Board.CheckState(0, 0), Board.CheckState(2,2)) &&
                !String.Equals(Board.CheckState(0,0), " ")
            ) {
                
                win = true;
                return win;
            } else if(

                String.Equals(Board.CheckState(0, 2), Board.CheckState(1,1)) &&
                String.Equals(Board.CheckState(0, 2), Board.CheckState(2,0)) &&
                !String.Equals(Board.CheckState(0, 2), " ")
            ) {
                Console.WriteLine("Here!");
                win = true;
                return win;
            }


            return win;

            }


        }

    }