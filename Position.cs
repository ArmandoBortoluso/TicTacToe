using System;

namespace TicTacToe {

    class Position {

        private int pos;

        public int Pos {

            get{return pos;}

            set{pos = value;}

        }


        public static void FindCoordinates(int pos, short[] coord) {

            switch(pos)
            {

                case 1:
                coord[0] = 0;
                coord[1] = 0;
                break;

                                
                case 2:
                coord[0] = 1;
                coord[1] = 0;
                break;

                                
                case 3:
                coord[0] = 2;
                coord[1] = 0;
                break;

                                
                case 4:
                coord[0] = 0;
                coord[1] = 1;
                break;

                                
                case 5:
                coord[0] = 1;
                coord[1] = 1;
                break;

                                
                case 6:
                coord[0] = 2;
                coord[1] = 1;
                break;

                                
                case 7:
                coord[0] = 0;
                coord[1] = 2;
                break;

                                
                case 8:
                coord[0] = 1;
                coord[1] = 2;
                break;

                                
                case 9:
                coord[0] = 2;
                coord[1] = 2;
                break;


            }

        }


    }
}