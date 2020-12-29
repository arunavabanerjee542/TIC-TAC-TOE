using System.Collections.Generic;
using System;
namespace TIC_TAC_TOE
{
    class Player :SystemUser
    {
        List<Move> AllMovesMade; 

        public Player()
        {
           // AllMovesMade = new List<Move>();
        }

        public Player(string n)
        {
            name = n;
            AllMovesMade = new List<Move>();
        }


        public Move MakeMove(int[,] grid)
        {
            int c = 0; int r = 0;
            Console.WriteLine(" Enter your ROW choice ");
            try
            {
                r = Convert.ToInt32( Console.ReadLine());
            }
            catch(Exception e)
            {

               Console.WriteLine(" INVALID CHOICE ");
              return  MakeMove(grid);
            }

            Console.WriteLine(" Enter your COLOUMN choice ");
            try
            {
                 c = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine(" INVALID CHOICE ");
           return MakeMove(grid);
            }

            IValidator validate = new Validator();

            Move m = new Move(r, c);

            if(validate.IsValidMove(m,grid))
            {
                AllMovesMade.Add(m);
                return m;
            }
            else
            {
                Console.WriteLine(" Invalid choice ");
               return MakeMove(grid);
            }




        }


        public void ShowAllMyMoves()
        {
            foreach(var x in AllMovesMade)
                {

              Console.WriteLine(x.row + " " + x.col);
                Console.WriteLine();
            }

        }


        public override string ToString()
        {
            return name;
        }







    }
}