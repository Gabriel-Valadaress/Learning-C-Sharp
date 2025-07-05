using System;
using ConsoleChess.Pieces;

namespace ConsoleChess.Board;

public class Position
{
    public int Row { get; set; }
    public int Column { get; set; }

    public Position(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int PositionInTheList()
    {
        return ((Row - 1) * 8 + Column - 1);
    }
}
