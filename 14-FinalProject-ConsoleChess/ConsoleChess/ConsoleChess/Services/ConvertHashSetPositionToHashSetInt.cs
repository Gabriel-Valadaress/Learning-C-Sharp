using System;
using ConsoleChess.Board;

namespace ConsoleChess.Services;

public static class ConvertHashSetPositionToHashSetInt
{
    public static HashSet<int> Convert(HashSet<Position> positions) {

        HashSet<int> list = new HashSet<int>();

        foreach (Position position in positions)
        {
            int id = (position.Row - 1) * 8 + (position.Column - 1);
            list.Add(id);
        }

        return list;
    }
}
