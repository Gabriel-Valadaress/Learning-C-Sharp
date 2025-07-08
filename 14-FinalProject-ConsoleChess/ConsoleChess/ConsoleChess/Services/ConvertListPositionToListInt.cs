using System;
using ConsoleChess.Board;

namespace ConsoleChess.Services;

public static class ConvertListPositionToListInt
{
    public static List<int> Convert(List<Position> positions) {

        List<int> list = new List<int>();

        foreach (Position position in positions)
        {
            int id = (position.Row - 1) * 8 + (position.Column - 1);
            list.Add(id);
        }

        return list;
    }
}
