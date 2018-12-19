namespace Lab___5
{
    public class ChessBoard
    {
        private string[,] chessboard;
        public const int xValue = 8;
        public const int yValue = 8;
        public string rowBorder = ("+").PadRight(4, '-');
        public string columnBorder = ("|");
        public ChessPiece chessPiece;
        public bool endProgram = false;
        public void ChessBoardHeader()
        {
            System.Console.WriteLine();
            System.Console.WriteLine(
                                (
                                ("    ") +
                                ("A").PadLeft(4, ' ') +
                                ("B").PadLeft(4, ' ') +
                                ("C").PadLeft(4, ' ') +
                                ("D").PadLeft(4, ' ') +
                                ("E").PadLeft(4, ' ') +
                                ("F").PadLeft(4, ' ') +
                                ("G").PadLeft(4, ' ') +
                                ("H").PadLeft(4, ' '))
                             );
        }

        public ChessBoard()
        {
            
        }

        public void PrintBoard()
        {
         

            chessboard = new string[xValue, yValue];
            chessPiece = new ChessPiece();

            while (endProgram == false)
            {
                System.Console.Clear();
                ChessBoardHeader();
                try
                {
                    for (int rowX = 0; rowX < xValue; rowX++)
                    {
                        //Indent
                        System.Console.Write(("").PadRight(5));

                        for (int columnY = 0; columnY < yValue; columnY++)
                        {
                            //Draw Rows
                            System.Console.Write(rowBorder);
                        }
                        System.Console.Write("+\n");

                        for (int columnY = 0; columnY < yValue; columnY++)
                        {

                            if (columnY == 0)
                            {
                                // Y-Axis Header + Indent
                                System.Console.Write((((rowX + 1).ToString().PadLeft(4)) + " ").PadRight(3));
                            }
                            else
                            {
                                //System.Console.Write(" ");
                            }
                            System.Console.Write((columnBorder).PadRight(2));
                            //Print Symbol or Space?
                            System.Console.Write((ChessPiece.chessPiece[rowX, columnY]).PadLeft(1).PadRight(2));
                        }
                        //End of Column
                        System.Console.Write(("|\n").PadLeft(2));
                    }


                    System.Console.Write((" ").PadRight(5));
                    for (int columnY = 0; columnY < yValue; columnY++)
                    {
                        System.Console.Write((rowBorder));
                    }
                    System.Console.Write("+\n\n");
                    System.Console.WriteLine();
                    chessPiece.MovePiece();
                    if (endProgram == true)
                    {
                        break;
                    }
                    if (endProgram == false)
                    {
                        continue;
                    }
                }
                //
                catch
                {
                }
            }
        }
    }
}
