using System;
using ConsoleChess.Pieces;
using ConsoleChess.Services;

namespace ConsoleChess.Board
{
    public static class Screen
    {
        public static void ShowBoard(Piece[] board)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   a  b  c  d  e  f  g  h");
            Console.ResetColor();

            for (int row = 8; row >= 1; row--)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{row} ");
                Console.ResetColor();

                for (int col = 1; col <= 8; col++)
                {
                    int id = (row - 1) * 8 + (col - 1);
                    Piece p = board[id];

                    bool whiteSquare = (row + col) % 2 == 0;
                    if (whiteSquare)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }


                    if (p.Name == "-")
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        if (p.Color == "White")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.Write($" {p.Name} ");
                    }
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" {row}");
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   a  b  c  d  e  f  g  h");
            Console.ResetColor();
        }

        public static void ShowBoardAfter(Piece[] pieces, int positionInTheArray)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   a  b  c  d  e  f  g  h");
            Console.ResetColor();

            for (int row = 8; row >= 1; row--)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{row} ");
                Console.ResetColor();

                for (int col = 1; col <= 8; col++)  
                {
                    int id = (row - 1) * 8 + (col - 1);
                    Piece p = pieces[id];

                    bool whiteSquare = (row + col) % 2 == 0;

                    List<int> possiblePositions = ConvertListPositionToListInt.Convert(pieces[positionInTheArray].PossibleMovement(pieces));

                    if (id == positionInTheArray)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    else if (possiblePositions.Contains(id))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (whiteSquare)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }


                    if (p.Name == "-")
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        if (p.Color == "White")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.Write($" {p.Name} ");
                    }
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" {row}");
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   a  b  c  d  e  f  g  h");
            Console.ResetColor();
        }
    }
}
