namespace TicTacToe {
    class Renderer {

        public static void Render() {
            string symbol;

            for(short y = 0; y < 3; y++) {
                for(short x = 0; x < 3; x++) {

                    symbol = Board.CheckState(x, y);
                    Console.Write(symbol);

                    if(x < 2) {
                        Console.Write("|");
                    } else {
                        Console.Write("\n");
                    }
                }
            }
    

    }

}
}