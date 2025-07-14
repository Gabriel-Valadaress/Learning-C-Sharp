using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class Pawn : Piece
{
    public Pawn(string name, string color, Position position) : base(name, color, position) { }

    public override HashSet<int> PossibleMovement(Piece[] pieces, int turnCount)
    {
        HashSet<int> possibleMovement = new HashSet<int>();

        if (Color == "White")
        {
            if (Position.Row == 2)
            {
                if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                    if (pieces[((Position.Row + 2) - 1) * 8 + (Position.Column - 1)].Name == "-")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 2, Position.Column)));
                    }
                }
            }

            if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
            }

            if (Position.Column < 8)
            {
                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                }
            }

            if (Position.Column > 1)
            {
                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                }
            }

            if (Position.Row == 5)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black" &&
                pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Name == "P" &&
                pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].TurnOfLastMovement == (turnCount - 1))
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                }

                if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black" &&
                pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Name == "P" &&
                pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].TurnOfLastMovement == (turnCount - 1))
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                }
            }
        }

        if (Color == "Black")
        {
            if (Position.Row == 7)
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column)));
                    if (pieces[((Position.Row - 2) - 1) * 8 + (Position.Column - 1)].Name == "-")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 2, Position.Column)));
                    }
                }
            }

            if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column)));
            }

            if (Position.Column < 8)
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column + 1)));
                }
            }

            if (Position.Column > 1)
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column - 1)));
                }
            }

            if (Position.Row == 4)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White" &&
                pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Name == "P" &&
                pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].TurnOfLastMovement == (turnCount - 1))
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column + 1)));
                }

                if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White" &&
                pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Name == "P" &&
                pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].TurnOfLastMovement == (turnCount - 1))
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column - 1)));
                }
            }
        }

        return possibleMovement;
    }

    public  List<Position> PossibleMovementCheck(Piece[] pieces, int turnCount)
    {
        
        return new List<Position>();
    }
}
