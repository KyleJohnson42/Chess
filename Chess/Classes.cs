using System;
using System.Collections.Generic;

namespace Chess
{
    public class Piece
    {
        //Properties
        public string Side { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public bool HasMoved { get; set; }           //For pawns.
 

        //Constructors
        public Piece() { }
        public Piece(string s, string n, string a)
        {
            Side = s;
            Name = n;
            Abbreviation = a;
            HasMoved = false;
        }


        //Methods
        public bool is_Valid_Move(Space current, Space target)
        {
            //Check if the target is consistent with rules of movement for the piece
            if (Name == "Pawn")
            {
                if (Side == "Black")
                {
                    if (target.ContainsPiece && target.CurrentPiece.Side != Side && Math.Abs(target.X - current.X) == 1 && target.Y == current.Y - 1) { return true; }

                    if (HasMoved)
                    {
                        if (target.X == current.X && target.Y == current.Y - 1) { return true; }
                        else { return false; }
                    }
                    else
                    {
                        if (target.X == current.X && ((target.Y == current.Y - 1) || (target.Y == current.Y - 2)) ) { return true; }
                        else { return false; }
                    }
                }

                else if (Side == "White")
                {
                    if (target.ContainsPiece && target.CurrentPiece.Side != Side && Math.Abs(target.X - current.X) == 1 && target.Y == current.Y + 1) { return true; }

                    if (HasMoved)
                    {
                        if (target.X == current.X && target.Y == current.Y + 1) { return true; }
                        else { return false; }
                    }
                    else
                    {
                        if (target.X == current.X && ((target.Y == current.Y + 1) || (target.Y == current.Y + 2)) ) { return true; }
                        else { return false; }
                    }
                }

                else
                {
                    return false;
                }
            }

            else if (Name == "Rook")
            {
                if (target.X == current.X || target.Y == current.Y) { return true; }
                else { return false; }
            }

            else if (Name == "Knight")
            {
                if (Math.Abs(target.X - current.X) == 2 && Math.Abs(target.Y - current.Y) == 1) { return true; }
                else if (Math.Abs(target.X - current.X) == 1 && Math.Abs(target.Y - current.Y) == 2) { return true; }
                else { return false; }
            }

            else if (Name == "Bishop")
            {
                if (Math.Abs(target.X - current.X) == Math.Abs(target.Y - current.Y)) { return true; }
                else { return false; }
            }

            else if (Name == "Queen")
            {
                if (target.X == current.X || target.Y == current.Y) { return true; }
                else if (Math.Abs(target.X - current.X) == Math.Abs(target.Y - current.Y)) { return true; }
                else { return false; }
            }

            else if (Name == "King")
            {
                if (Math.Abs(target.X - current.X) <= 1 && Math.Abs(target.Y - current.Y) <= 1) { return true; }
                else { return false; }
            }

            else
            {
                return false;
            }
        }

        public bool will_Collide(List<Space> Board, Space current, Space target)
        {
            //Assumes valid move
            if (!is_Valid_Move(current, target)) { return true; }

            int current_index = current.X + 8 * current.Y;

            if (Name == "King") { return false; }
            else if (Name == "Knight") { return false; }
            else if (Name == "Pawn")
            {
                if (Side == "White" && Board[current_index + 8].ContainsPiece) { return true; }
                else if (Side == "Black" && Board[current_index - 8].ContainsPiece) { return true; }
            }

            else if (Name == "Rook")
            {
                if (target.Y == current.Y && target.X < current.X)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        if (Board[current_index - i].ContainsPiece) { return true; }
                    }
                }
                else if (target.Y == current.Y && target.X > current.X)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        if (Board[current_index + i].ContainsPiece) { return true; }
                    }
                }
                else if (target.X == current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.Y - i > target.Y; i++)
                    {
                        if (Board[current_index - i * 8].ContainsPiece) { return true; }
                    }
                }
                else if (target.X == current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.Y + i < target.Y; i++)
                    {
                        if (Board[current_index + i * 8].ContainsPiece) { return true; }
                    }
                }
            }
            else if (Name == "Bishop")
            {
                if (target.X < current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        if (Board[current_index - i - 8 * i].ContainsPiece) { return true; }
                    }
                }
                else if (target.X < current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        if (Board[current_index - i + 8 * i].ContainsPiece) { return true; }
                    }
                }
                else if (target.X > current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        if (Board[current_index + i - 8 * i].ContainsPiece) { return true; }
                    }
                }
                else if (target.X > current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        if (Board[current_index + i + 8 * i].ContainsPiece) { return true; }
                    }
                }
            }
            else if (Name == "Queen")
            {
                if (target.Y == current.Y && target.X < current.X)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        if (Board[current_index - i].ContainsPiece) { return true; }
                    }
                }
                else if (target.Y == current.Y && target.X > current.X)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        if (Board[current_index + i].ContainsPiece) { return true; }
                    }
                }
                else if (target.X == current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.Y - i > target.Y; i++)
                    {
                        if (Board[current_index - i * 8].ContainsPiece) { return true; }
                    }
                }
                else if (target.X == current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.Y + i < target.Y; i++)
                    {
                        if (Board[current_index + i * 8].ContainsPiece) { return true; }
                    }
                }
                else if (target.X < current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        if (Board[current_index - i - 8 * i].ContainsPiece) { return true; }
                    }
                }
                else if (target.X < current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        if (Board[current_index - i + 8 * i].ContainsPiece) { return true; }
                    }
                }
                else if (target.X > current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        if (Board[current_index + i - 8 * i].ContainsPiece) { return true; }
                    }
                }
                else if (target.X > current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        if (Board[current_index + i + 8 * i].ContainsPiece) { return true; }
                    }
                }
            }
            return false;
        }

        public List<Space> Path(List<Space> Board, Space current, Space target)
        {
            //Returns all spaces in between current and target
            List<Space> path = new List<Space>();

            //Assumes valid move
            if (!is_Valid_Move(current, target)) { return path; }

            int current_index = current.X + 8 * current.Y;

            if (Name == "King") { return path; }
            else if (Name == "Pawn") { return path; }
            else if (Name == "Knight")
            {
                if (target.X == current.X - 2)
                {
                    if (target.Y == current.Y + 1)
                    {
                        path.Add(Board[current_index - 1]);
                        path.Add(Board[current_index - 2]);
                        path.Add(Board[current_index - 2 + 8]);
                    }
                    else if (target.Y == current.Y - 1)
                    {
                        path.Add(Board[current_index - 1]);
                        path.Add(Board[current_index - 2]);
                        path.Add(Board[current_index - 2 - 8]);
                    }
                }
                else if (target.X == current.X - 1)
                {
                    if (target.Y == current.Y + 2)
                    {
                        path.Add(Board[current_index + 8]);
                        path.Add(Board[current_index + 8 + 8]);
                        path.Add(Board[current_index + 8 + 8 - 1]);
                    }
                    else if (target.Y == current.Y - 2)
                    {
                        path.Add(Board[current_index - 8]);
                        path.Add(Board[current_index - 8 - 8]);
                        path.Add(Board[current_index - 8 - 8 - 1]);
                    }
                }
                else if (target.X == current.X + 1)
                {
                    if (target.Y == current.Y + 2)
                    {
                        path.Add(Board[current_index + 8]);
                        path.Add(Board[current_index + 8 + 8]);
                        path.Add(Board[current_index + 8 + 8 + 1]);
                    }
                    else if (target.Y == current.Y - 2)
                    {
                        path.Add(Board[current_index - 8]);
                        path.Add(Board[current_index - 8 - 8]);
                        path.Add(Board[current_index - 8 - 8 + 1]);
                    }
                }
                else if (target.X == current.X + 2)
                {
                    if (target.Y == current.Y + 1)
                    {
                        path.Add(Board[current_index + 1]);
                        path.Add(Board[current_index + 2]);
                        path.Add(Board[current_index + 2 + 8]);
                    }
                    else if (target.Y == current.Y - 1)
                    {
                        path.Add(Board[current_index + 1]);
                        path.Add(Board[current_index + 2]);
                        path.Add(Board[current_index + 2 - 8]);
                    }
                }
                return path;
            }
            else if (Name == "Rook")
            {
                if (target.Y == current.Y && target.X < current.X)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        path.Add(Board[current_index - i]);
                    }
                }
                else if (target.Y == current.Y && target.X > current.X)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        path.Add(Board[current_index + i]);
                    }
                }
                else if (target.X == current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.Y - i > target.Y; i++)
                    {
                        path.Add(Board[current_index - i * 8]);
                    }
                }
                else if (target.X == current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.Y + i < target.Y; i++)
                    {
                        path.Add(Board[current_index + i * 8]);
                    }
                }
                return path;
            }
            else if (Name == "Bishop")
            {
                if (target.X < current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        path.Add(Board[current_index - i - 8 * i]);
                    }
                }
                else if (target.X < current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        path.Add(Board[current_index - i + 8 * i]);
                    }
                }
                else if (target.X > current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        path.Add(Board[current_index + i - 8 * i]);
                    }
                }
                else if (target.X > current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        path.Add(Board[current_index + i + 8 * i]);
                    }
                }
                return path;
            }
            else if (Name == "Queen")
            {
                if (target.Y == current.Y && target.X < current.X)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        path.Add(Board[current_index - i]);
                    }
                }
                else if (target.Y == current.Y && target.X > current.X)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        path.Add(Board[current_index + i]);
                    }
                }
                else if (target.X == current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.Y - i > target.Y; i++)
                    {
                        path.Add(Board[current_index - i * 8]);
                    }
                }
                else if (target.X == current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.Y + i < target.Y; i++)
                    {
                        path.Add(Board[current_index + i * 8]);
                    }
                }
                else if (target.X < current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        path.Add(Board[current_index - i - 8 * i]);
                    }
                }
                else if (target.X < current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.X - i > target.X; i++)
                    {
                        path.Add(Board[current_index - i + 8 * i]);
                    }
                }
                else if (target.X > current.X && target.Y < current.Y)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        path.Add(Board[current_index + i - 8 * i]);
                    }
                }
                else if (target.X > current.X && target.Y > current.Y)
                {
                    for (int i = 1; current.X + i < target.X; i++)
                    {
                        path.Add(Board[current_index + i + 8 * i]);
                    }
                }
                return path;
            }
            return path;
        }
    }

    public class Space
    {
        //Properties
        public int X { get; set; }
        public int Y { get; set; }
        public Piece CurrentPiece { get; set; }
        public bool ContainsPiece { get; set; }

        //Constructors
        public Space() { }
        public Space(int x, int y, Piece p, bool c)
        {
            X = x;
            Y = y;
            CurrentPiece = p;
            ContainsPiece = c;
        }
        public Space(int x, int y)
        {
            X = x;
            Y = y;
            CurrentPiece = new Piece();
            ContainsPiece = false;
        }
    }
}
