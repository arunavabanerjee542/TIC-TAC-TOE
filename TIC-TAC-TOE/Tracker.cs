namespace TIC_TAC_TOE
{
    class Tracker : SystemUser
    {

        public void UpdateBoard(Move m , int sign,int[,] board)
        {
            board[m.row, m.col] = sign;

        }


        public bool TrackWinner(Move m, int[,] board)
        {
            int r = m.row;
            int c = m.col;
            int sign = board[r, c];

            int comp = 0;

             //horizontal
             for(int i=0;i>=0 && i<3; i++)
              {
                if(board[r,i]== sign)
                {
                    comp++;

                }
              }

             if(comp == 3)
            {
                return true;
            }
            comp = 0;

            //vertical
            for (int i = 0; i >= 0 && i < 3; i++)
            {
                if (board[i, c] == sign)
                {
                    comp++;

                }
            }

            if (comp == 3)
            {
                return true;
            }

            comp = 0;

            //diagonal 1
            for (int i = 0; i >= 0 && i < 3; i++)
            {
                if (board[i, i] == sign)
                {
                    comp++;

                }
            }

            if (comp == 3)
            {
                return true;
            }

            comp = 0;


            //diagonal 2
            for (int i = 0; i >= 0 && i < 3; i++)
            {
                if (board[i, 3-(i+1)] == sign)
                {
                    comp++;

                }
            }

            if (comp == 3)
            {
                return true;
            }

           return false;







        }



       











    }
}