using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___5
{
    public class ChessPiece
    {
        public const string symbol = "X";
        public const string space = " ";
        private int currentX;
        private int currentY;
        private int inputX;
        private int inputY;
        public bool endProgram;
        public static string[,] chessPiece = new string[ChessBoard.xValue, ChessBoard.yValue];
        //public static string[,] chessPieces;
        //public string[,] InitialPosition;

        public ChessPiece()
        {
            chessPiece = new string[ChessBoard.xValue, ChessBoard.yValue];
            InitialPosition();
        }
        public void InitialPosition()
        {
            chessPiece = new string[ChessBoard.xValue, ChessBoard.yValue];

            for (int row = 0; row < ChessBoard.xValue; row++)
            {
                for (int column = 0; column < ChessBoard.yValue; column++)
                {
                    //place X into first 2 and last 2 rows of the array
                    if (row == 0 || row == 1 || row == 7 || row == 6)
                    {
                        chessPiece[row, column] = symbol;
                    }
                    else
                    {
                        chessPiece[row, column] = space;
                    }
                }
            }
        }
        public int HeaderFromLettersToNumbers(string xValue)
        {
            int x = 0;
            if (xValue == "A")
            {
                x = 0;
            }
            if (xValue == "B")
            {
                x = 1;
                return x;
            }
            if (xValue == "C")
            {
                x = 2;
                return x;
            }
            if (xValue == "D")
            {
                x = 3;
                return x;
            }
            if (xValue == "E")
            {
                x = 4;
                return x;
            }
            if (xValue == "F")
            {
                x = 5;
                return x;
            }
            if (xValue == "G")
            {
                x = 6;
                return x;
            }
            if (xValue == "H")
            {
                x = 7;
                return x;
            }
            if (xValue != "A" && 
                xValue != "B" &&
                xValue != "C" &&
                xValue != "D" &&
                xValue != "E" &&
                xValue != "F" &&
                xValue != "G" &&
                xValue != "H" 
                )
            {
                this.Exit();
            }
            return x;
        }

        public void MovePiece(bool passTheBool)
        {
            //string CurrentX, int CurrentY, string TargetX, int TargetY  FORMER PARAMETERS
            string CurrentX;
            int CurrentY;
            string TargetX;
            int TargetY;

            System.Console.WriteLine("Enter Current X-Axis Coordinate");
            CurrentX = System.Console.ReadLine().ToUpper().Substring(0, 1);
            int xValToInt1 = HeaderFromLettersToNumbers(CurrentX);

            System.Console.WriteLine("Enter Current Y-Axis Coordinate");
            CurrentY = int.Parse(System.Console.ReadLine());
            CurrentY = CurrentY - 1;
            if (currentY <= 0 && currentY >= 7)
            {
                passTheBool = false;
            }
            else
            {
                this.Exit();
            }

            System.Console.WriteLine("Enter Target X-Axis Coordinate");
            TargetX = System.Console.ReadLine().ToUpper().Substring(0, 1);
            int xValToInt2 = HeaderFromLettersToNumbers(TargetX);


            System.Console.WriteLine("Enter Target Y-Axis Coordinate");
            TargetY = int.Parse(System.Console.ReadLine());
            TargetY = TargetY - 1;
            if (TargetY <= 0 && TargetY >= 7)
            {
                passTheBool = false;
            }
            else
            {
                this.Exit();
            }

            //I dont know why I had to flip flop X and Y?
            chessPiece[CurrentY, xValToInt1] = space;
            chessPiece[TargetY, xValToInt2] = symbol;
        }
        public void Exit()
        {
            System.Console.WriteLine("Index out of range.");
            System.Console.WriteLine("Goodbye.");
            System.Console.ReadLine();
            System.Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
