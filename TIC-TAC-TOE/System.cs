using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    class System
    {
       public void AnnounceWinner(Player p)
        {
            if (p != null)
            {
                Console.WriteLine(" THE WINNER IS " + p);
            }
            else
            {
                Console.WriteLine(" MATCH DRAW ");
            }
        }

    }
}
