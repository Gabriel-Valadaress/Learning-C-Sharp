using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class King : Piece
{
    public King (string name, string color, Position position) : base(name, color, position) { }

    public override HashSet<int> PossibleMovement(Piece[] pieces, int turnCount)
    {
        HashSet<int> possibleMovement = new HashSet<int>();

        if (Position.Row > 1)
        {
            if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column)));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column)));
                }
            }
            else
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column)));
                }
            }

            if (Position.Column > 1)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                    }
                }
                else
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                    }
                }

                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column - 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column - 1)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column - 1)));
                    }
                }
            }

            if (Position.Column < 8)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                    }
                }
                else
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                    }
                }

                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column + 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column + 1)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column + 1)));
                    }
                }
            }

            if (Position.Row < 8)
            {
                if (Position.Column > 1)
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                    }
                    else if (Color == "White")
                    {
                        if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                        {
                            possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                        }
                    }
                    else
                    {
                        if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                        {
                            possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                        }
                    }
                }

                if (Position.Column < 8)
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                    }
                    else if (Color == "White")
                    {
                        if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                        {
                            possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                        }
                    }
                    else
                    {
                        if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                        {
                            possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                        }
                    }
                }

                if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                    }
                }
            }
        }
        else
        {
            if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                }
            }
            else
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                }
            }

            if (Position.Column > 1)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                    }
                }
                else
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                    }
                }

                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                    }
                }
            }

            if (Position.Column < 8)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                    }
                }
                else
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                    }
                }

                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                    }
                }
            }
        }

        if (InitialPosition == true)
        {
            if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column + 2) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column + 3) - 1)].InitialPosition == true)
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 2)));
            }

            if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column - 2) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column - 3) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column - 4) - 1)].InitialPosition == true)
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 2)));
            }
        }

        return possibleMovement;
    }
}
