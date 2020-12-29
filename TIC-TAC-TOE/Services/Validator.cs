using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    class Validator : IValidator
    {
        public bool IsValidMove(Move m , int[,] grid)
        {

            if (m.row < 0 || m.row >= 3 || m.col < 0 || m.col >= 3 || grid[m.row,m.col] != 0)
            {
                return false;
            }

            return true;

        }

        public bool IsValidMove()
        {
            throw new NotImplementedException();
        }
    }
}
