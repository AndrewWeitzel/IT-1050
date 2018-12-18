using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___5
{
    public class Move : ChessPiece
    {
        private int targetX;
        private int targetY;
        private int destinationX;
        private int destinationY;
        public bool exit;
        public Move()
        {
            targetX = 0;
            targetY = 0;
            destinationX = 0;
            destinationY = 0;
        }

    }
  
}
