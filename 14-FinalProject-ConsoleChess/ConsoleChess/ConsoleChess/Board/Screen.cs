using System;

namespace ConsoleChess.Board;

public static class Screen
{
    public static void FirstRow()
    {
        System.Console.WriteLine("  a b c d e f g h");
    }
    public static void LastRow()
    {
        System.Console.WriteLine("  a b c d e f g h");
    }

    public static void PrintRow()
    {
        System.Console.WriteLine("8 - - - - - - - - 8");
    }
    public static void ShowBoard()
    {
        FirstRow();
        for (int i = 8; i > 0; i--)
        {
            System.Console.WriteLine("");
        }
        LastRow();
    }
}
