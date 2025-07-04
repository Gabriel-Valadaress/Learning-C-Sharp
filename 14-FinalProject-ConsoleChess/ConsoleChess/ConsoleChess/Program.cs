using ConsoleChess.Board;
using ConsoleChess.Pieces;

namespace ConsoleChess
{
    public class Program
    {
        static void Main(string[] args)
        {
            Piece[] pieces = new Piece[64];
            Screen.ShowBoard();
        }

        static void InitialPosition()
        {
            Piece piece01 = new Piece("", "", new Position(1, 1));
        }
    }
}
