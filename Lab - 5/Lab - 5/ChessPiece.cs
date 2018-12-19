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
        
        public bool endProgram;
        public static string[,] chessPiece = new string[ChessBoard.xValue, ChessBoard.yValue];
        

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
            int x = 1000;
            if (xValue == "A")
            {
                x = 0;
                return x;
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
            if(xValue!="A"&&xValue!="B"&&xValue!="C"&&xValue!="D"&&xValue!="E"&&xValue!="F"&&xValue!="G"&&xValue!="H")
            {
                endProgram = true;
            }
                return x;
        }

        public void MovePiece()
        {

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
                if (CurrentY <= 0 && CurrentY >= 7)
                {
                    
                }
                else
                {
                    endProgram = true;
                }

                    System.Console.WriteLine("Enter Target X-Axis Coordinate");
                    TargetX = System.Console.ReadLine().ToUpper().Substring(0, 1);
                    int xValToInt2 = HeaderFromLettersToNumbers(TargetX);



                        System.Console.WriteLine("Enter Target Y-Axis Coordinate");
                        TargetY = int.Parse(System.Console.ReadLine());
                        TargetY = TargetY - 1;
                        if (TargetY <= 0 && TargetY >= 7)
                        {

                        }
                        else
                        {
                            endProgram = true;
                        }

            if (CurrentY < 0 || CurrentY > 7 || xValToInt1 < 0 || xValToInt1 > 7)
            {
                System.Console.WriteLine("The current chesspiece does not exist.");
                this.Exit();
            }
            if (TargetY < 0 || TargetY > 7 || xValToInt2 < 0 || xValToInt2 > 7)
            {
                System.Console.WriteLine("The target chessboard space does not exist.");
                this.Exit();
            }
            chessPiece[CurrentY, xValToInt1] = space;
                        chessPiece[TargetY, xValToInt2] = symbol;
        }
        public void Exit()
        {
            System.Console.WriteLine("Index out of range! \n" + "Closing program. \n" + "Press any key...");
            
            System.Console.ReadLine();
            System.Console.ReadKey();
            Environment.Exit(0);
            //commit test
        }
    }

}

