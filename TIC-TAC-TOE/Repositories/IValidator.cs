﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    interface IValidator
    {
        bool IsValidMove(Move m , int[,] grid);
    }
}
