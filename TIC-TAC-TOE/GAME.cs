using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    class GAME
    {
        int[,] board = new int[3,3];
        Player p1;
        Player p2;
        Tracker tracker;


        public GAME ()
        {
            p1 = new Player(" RAM ");
            p2 = new Player(" SHYAM ");
            tracker = new Tracker();
        }

        public Player play()
        {
            int count = 0;
           
            while(count<9)
            {

                


               if(count%2==0)
                {
                    CheckSpacesAvailable(p1);

                    Console.WriteLine(" Player 1 turn ");
                   var mov = p1.MakeMove(board);
                    tracker.UpdateBoard(mov, 1, board);
                   bool  b = tracker.TrackWinner(mov, board);
                    if(b)
                    {
                        return p1;
                    }

                    count++;

                }

                else
                {
                    CheckSpacesAvailable(p2);

                    Console.WriteLine(" Player 2 turn ");
                    var mov = p2.MakeMove(board);
                    tracker.UpdateBoard(mov, 2, board);
                    bool b =tracker.TrackWinner(mov, board);
                    if(b)
                    {
                        return p2;
                    }

                    count++;

                }

               



            }

            return null;


        }



        public void CheckSpacesAvailable(Player p)
        {
            Console.WriteLine(" WANT TO KNOW THE AVAILABLE SPACES ");
            Console.WriteLine(" 1--> YES ");
            Console.WriteLine(" 2 ---> NO ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                p.ViewGridSpacesAvailable(board);
            }

        }




    }
}
