﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    class Program
    {
        static void Main(string[] args)
        {
            GAME tictactoe = new GAME();

           Player winner =  tictactoe.play();


            Console.WriteLine(winner);
          


        }
    }
}
