using System;
using ConsoleChess.Pieces;

namespace ConsoleChess.Board;

public static class VerifyPosition
{
    public static Piece WhatIsInThePosition(Position position)
    {
        return new Piece("", "", new Position(1,1));
    }

}
