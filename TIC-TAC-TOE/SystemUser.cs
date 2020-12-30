using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    class SystemUser : Person
    {
        public void ViewGridSpacesAvailable(int [,] board)
        {
            Console.WriteLine(" N/A ---> NOT AVAILABLE ");
            Console.WriteLine(" A ---> AVAILABLE ");
            Console.WriteLine("----------------------------------------");
            
           for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if(board[i,j] == 0)
                    {
                        Console.Write("("+i +","+j+")" + "A   ");
                       
                    }
                    else
                    {
                        Console.Write("(" + i + "," + j + ")" + "N/A   ");
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine("-------------------------------------");



        }

    }
}
