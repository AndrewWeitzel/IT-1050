using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___5
{
    class ChessBoard
    {
        //declare demension
        public const int x = 8;
        public const int y = 8;
        //declare 2d array
        public static string[,] chessboard;

        private ChessPiece chessPiece;        //removed because it is accesed through the move class, which is inheritied

        private Move move;

        public ChessBoard()
        {
            //chessPiece = new ChessPiece();
            move = new Move();
            chessboard = new string[x, y];
            ChessBoardHorizontalSymbol = ("+").PadRight(4, '-');
            ChessBoardVerticalSymbol = ("|");
        }

        public string ChessBoardHorizontalSymbol;
        public string ChessBoardVerticalSymbol;
        public void BoardHeader()
        {

        }
        public void PrintBoard()
        {

            Console.Clear();
            // x-axis header
            Console.WriteLine(
                                (" ")+
                                ("A").PadLeft(4, ' ') +
                                ("B").PadLeft(4, ' ') +
                                ("C").PadLeft(4, ' ') +
                                ("D").PadLeft(4, ' ') +
                                ("E").PadLeft(4, ' ') +
                                ("F").PadLeft(4, ' ') +
                                ("G").PadLeft(4, ' ') +
                                ("H").PadLeft(4, ' ')
                             );
        
            for (int rowX = 0; rowX < x; rowX++)
            {
                //creating the indent for the board
                System.Console.Write("  ");
                // x-axis header
                for (int columnY = 0; columnY < y; columnY++)
                {
                    System.Console.Write(ChessBoardHorizontalSymbol);
                }
                System.Console.Write("+\n");
                
                for (int columnY = 0; columnY < y; columnY++)
                {
                    // y-axis header
                    System.Console.Write((rowX) + " ");
                    // center piece on the board-square                                         \\\\Try PadRight()///
                    System.Console.Write(ChessBoardVerticalSymbol + ChessPiece.coordinates[rowX, columnY] + " ");
                    
                }

                System.Console.Write(("|\n").PadLeft(4));
            }
            //close the board
            System.Console.Write((" ").PadRight(2));
            for (int columnY = 0; columnY < y; columnY++)
            {
                System.Console.Write((ChessBoardHorizontalSymbol));
            }
            System.Console.Write("+");
            System.Console.Read();
        }
        public void XYSpace()
        {
            string space;
            space = ("+").PadRight(3, '-');
            System.Console.WriteLine(space);
        }
    }
}


