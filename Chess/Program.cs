using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static List<Space> Starting_Board()
        {
            List<Space> Board = new List<Space>();

            Board.Add(new Space(0, 0, new Piece("White", "Rook", "WR"), true));
            Board.Add(new Space(1, 0, new Piece("White", "Knight", "WN"), true));
            Board.Add(new Space(2, 0, new Piece("White", "Bishop", "WB"), true));
            Board.Add(new Space(3, 0, new Piece("White", "Queen", "WQ"), true));
            Board.Add(new Space(4, 0, new Piece("White", "King", "WK"), true));
            Board.Add(new Space(5, 0, new Piece("White", "Bishop", "WB"), true));
            Board.Add(new Space(6, 0, new Piece("White", "Knight", "WN"), true));
            Board.Add(new Space(7, 0, new Piece("White", "Rook", "WR"), true));
            Board.Add(new Space(0, 1, new Piece("White", "Pawn", "WP"), true));
            Board.Add(new Space(1, 1, new Piece("White", "Pawn", "WP"), true));
            Board.Add(new Space(2, 1, new Piece("White", "Pawn", "WP"), true));
            Board.Add(new Space(3, 1, new Piece("White", "Pawn", "WP"), true));
            Board.Add(new Space(4, 1, new Piece("White", "Pawn", "WP"), true));
            Board.Add(new Space(5, 1, new Piece("White", "Pawn", "WP"), true));
            Board.Add(new Space(6, 1, new Piece("White", "Pawn", "WP"), true));
            Board.Add(new Space(7, 1, new Piece("White", "Pawn", "WP"), true));
            Board.Add(new Space(0, 2, new Piece(), false));
            Board.Add(new Space(1, 2, new Piece(), false));
            Board.Add(new Space(2, 2, new Piece(), false));
            Board.Add(new Space(3, 2, new Piece(), false));
            Board.Add(new Space(4, 2, new Piece(), false));
            Board.Add(new Space(5, 2, new Piece(), false));
            Board.Add(new Space(6, 2, new Piece(), false));
            Board.Add(new Space(7, 2, new Piece(), false));
            Board.Add(new Space(0, 3, new Piece(), false));
            Board.Add(new Space(1, 3, new Piece(), false));
            Board.Add(new Space(2, 3, new Piece(), false));
            Board.Add(new Space(3, 3, new Piece(), false));
            Board.Add(new Space(4, 3, new Piece(), false));
            Board.Add(new Space(5, 3, new Piece(), false));
            Board.Add(new Space(6, 3, new Piece(), false));
            Board.Add(new Space(7, 3, new Piece(), false));
            Board.Add(new Space(0, 4, new Piece(), false));
            Board.Add(new Space(1, 4, new Piece(), false));
            Board.Add(new Space(2, 4, new Piece(), false));
            Board.Add(new Space(3, 4, new Piece(), false));
            Board.Add(new Space(4, 4, new Piece(), false));
            Board.Add(new Space(5, 4, new Piece(), false));
            Board.Add(new Space(6, 4, new Piece(), false));
            Board.Add(new Space(7, 4, new Piece(), false));
            Board.Add(new Space(0, 5, new Piece(), false));
            Board.Add(new Space(1, 5, new Piece(), false));
            Board.Add(new Space(2, 5, new Piece(), false));
            Board.Add(new Space(3, 5, new Piece(), false));
            Board.Add(new Space(4, 5, new Piece(), false));
            Board.Add(new Space(5, 5, new Piece(), false));
            Board.Add(new Space(6, 5, new Piece(), false));
            Board.Add(new Space(7, 5, new Piece(), false));
            Board.Add(new Space(0, 6, new Piece("Black", "Pawn", "BP"), true));
            Board.Add(new Space(1, 6, new Piece("Black", "Pawn", "BP"), true));
            Board.Add(new Space(2, 6, new Piece("Black", "Pawn", "BP"), true));
            Board.Add(new Space(3, 6, new Piece("Black", "Pawn", "BP"), true));
            Board.Add(new Space(4, 6, new Piece("Black", "Pawn", "BP"), true));
            Board.Add(new Space(5, 6, new Piece("Black", "Pawn", "BP"), true));
            Board.Add(new Space(6, 6, new Piece("Black", "Pawn", "BP"), true));
            Board.Add(new Space(7, 6, new Piece("Black", "Pawn", "BP"), true));
            Board.Add(new Space(0, 7, new Piece("Black", "Rook", "BR"), true));
            Board.Add(new Space(1, 7, new Piece("Black", "Knight", "BN"), true));
            Board.Add(new Space(2, 7, new Piece("Black", "Bishop", "BB"), true));
            Board.Add(new Space(3, 7, new Piece("Black", "Queen", "BQ"), true));
            Board.Add(new Space(4, 7, new Piece("Black", "King", "BK"), true));
            Board.Add(new Space(5, 7, new Piece("Black", "Bishop", "BB"), true));
            Board.Add(new Space(6, 7, new Piece("Black", "Knight", "BN"), true));
            Board.Add(new Space(7, 7, new Piece("Black", "Rook", "BR"), true));

            return Board;
        }

        static void Display_Board(List<Space> Board, List<Piece> Captured_Pieces)
        {
            Console.WriteLine();
            Console.WriteLine("   -------- -------- -------- -------- -------- -------- -------- -------- ");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.Write("7 |   ");
            if (Board[56].ContainsPiece) { Console.Write(Board[56].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[57].ContainsPiece) { Console.Write(Board[57].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[58].ContainsPiece) { Console.Write(Board[58].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[59].ContainsPiece) { Console.Write(Board[59].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[60].ContainsPiece) { Console.Write(Board[60].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[61].ContainsPiece) { Console.Write(Board[61].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[62].ContainsPiece) { Console.Write(Board[62].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[63].ContainsPiece) { Console.Write(Board[63].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.WriteLine("   |");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.WriteLine("   -------- -------- -------- -------- -------- -------- -------- -------- ");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.Write("6 |   ");
            if (Board[48].ContainsPiece) { Console.Write(Board[48].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[49].ContainsPiece) { Console.Write(Board[49].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[50].ContainsPiece) { Console.Write(Board[50].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[51].ContainsPiece) { Console.Write(Board[51].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[52].ContainsPiece) { Console.Write(Board[52].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[53].ContainsPiece) { Console.Write(Board[53].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[54].ContainsPiece) { Console.Write(Board[54].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[55].ContainsPiece) { Console.Write(Board[55].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.WriteLine("   |");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.WriteLine("   -------- -------- -------- -------- -------- -------- -------- -------- ");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.Write("5 |   ");
            if (Board[40].ContainsPiece) { Console.Write(Board[40].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[41].ContainsPiece) { Console.Write(Board[41].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[42].ContainsPiece) { Console.Write(Board[42].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[43].ContainsPiece) { Console.Write(Board[43].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[44].ContainsPiece) { Console.Write(Board[44].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[45].ContainsPiece) { Console.Write(Board[45].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[46].ContainsPiece) { Console.Write(Board[46].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[47].ContainsPiece) { Console.Write(Board[47].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.WriteLine("   |");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.WriteLine("   -------- -------- -------- -------- -------- -------- -------- -------- ");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.Write("4 |   ");
            if (Board[32].ContainsPiece) { Console.Write(Board[32].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[33].ContainsPiece) { Console.Write(Board[33].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[34].ContainsPiece) { Console.Write(Board[34].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[35].ContainsPiece) { Console.Write(Board[35].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[36].ContainsPiece) { Console.Write(Board[36].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[37].ContainsPiece) { Console.Write(Board[37].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[38].ContainsPiece) { Console.Write(Board[38].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[39].ContainsPiece) { Console.Write(Board[39].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.WriteLine("   |");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.WriteLine("   -------- -------- -------- -------- -------- -------- -------- -------- ");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.Write("3 |   ");
            if (Board[24].ContainsPiece) { Console.Write(Board[24].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[25].ContainsPiece) { Console.Write(Board[25].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[26].ContainsPiece) { Console.Write(Board[26].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[27].ContainsPiece) { Console.Write(Board[27].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[28].ContainsPiece) { Console.Write(Board[28].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[29].ContainsPiece) { Console.Write(Board[29].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[30].ContainsPiece) { Console.Write(Board[30].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[31].ContainsPiece) { Console.Write(Board[31].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.WriteLine("   |");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.WriteLine("   -------- -------- -------- -------- -------- -------- -------- -------- ");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.Write("2 |   ");
            if (Board[16].ContainsPiece) { Console.Write(Board[16].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[17].ContainsPiece) { Console.Write(Board[17].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[18].ContainsPiece) { Console.Write(Board[18].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[19].ContainsPiece) { Console.Write(Board[19].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[20].ContainsPiece) { Console.Write(Board[20].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[21].ContainsPiece) { Console.Write(Board[21].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[22].ContainsPiece) { Console.Write(Board[22].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[23].ContainsPiece) { Console.Write(Board[23].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.WriteLine("   |");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.WriteLine("   -------- -------- -------- -------- -------- -------- -------- -------- ");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.Write("1 |   ");
            if (Board[8].ContainsPiece) { Console.Write(Board[8].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[9].ContainsPiece) { Console.Write(Board[9].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[10].ContainsPiece) { Console.Write(Board[10].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[11].ContainsPiece) { Console.Write(Board[11].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[12].ContainsPiece) { Console.Write(Board[12].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[13].ContainsPiece) { Console.Write(Board[13].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[14].ContainsPiece) { Console.Write(Board[14].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[15].ContainsPiece) { Console.Write(Board[15].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.WriteLine("   |");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.WriteLine("   -------- -------- -------- -------- -------- -------- -------- -------- ");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.Write("0 |   ");
            if (Board[0].ContainsPiece) { Console.Write(Board[0].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[1].ContainsPiece) { Console.Write(Board[1].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[2].ContainsPiece) { Console.Write(Board[2].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[3].ContainsPiece) { Console.Write(Board[3].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[4].ContainsPiece) { Console.Write(Board[4].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[5].ContainsPiece) { Console.Write(Board[5].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[6].ContainsPiece) { Console.Write(Board[6].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.Write("   |   ");
            if (Board[7].ContainsPiece) { Console.Write(Board[7].CurrentPiece.Abbreviation); } else { Console.Write("  "); }
            Console.WriteLine("   |");
            Console.WriteLine("  |        |        |        |        |        |        |        |        |");
            Console.WriteLine("   -------- -------- -------- -------- -------- -------- -------- -------- ");
            Console.WriteLine("      0         1        2        3        4        5        6        7");
            Console.WriteLine();
            Console.WriteLine("Captured pieces:");
            Console.Write("White: ");
            for (int i = 0; i < Captured_Pieces.Count; i++)
            {
                if (Captured_Pieces[i].Side == "White") { Console.Write(Captured_Pieces[i].Name + " "); }
            }
            Console.WriteLine();
            Console.Write("Black: ");
            for (int i = 0; i < Captured_Pieces.Count; i++)
            {
                if (Captured_Pieces[i].Side == "Black") { Console.Write(Captured_Pieces[i].Name + " "); }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static bool Check(List<Space> Board, string turn)
        {
            Space king_space = new Space();
            king_space.ContainsPiece = false;

            //Locate king's space
            for (int i = 0; i < Board.Count; i++)
            {
                if (Board[i].ContainsPiece && Board[i].CurrentPiece.Name == "King" && Board[i].CurrentPiece.Side == turn) { king_space = Board[i]; }
            }

            //If a king is not found, return false
            if (!king_space.ContainsPiece) { return false; }

            //Scan for opposing pieces, and check if they threaten the king's space
            for (int i = 0; i < Board.Count; i++)
            {
                if (Board[i].ContainsPiece && Board[i].CurrentPiece.Side != turn)
                {
                    Space threat_space = Board[i];
                    Piece threat_piece = Board[i].CurrentPiece;
                    if (threat_piece.is_Valid_Move(threat_space, king_space) && !threat_piece.will_Collide(Board, threat_space, king_space)) { return true; }               
                }
            }

            return false;
        }

        //INCOMPLETE
        static bool Checkmate(List<Space> Board, string turn)
        {
            bool can_run = true;
            bool can_attack = true;
            bool can_block = true;

            List<Space> target_spaces = new List<Space>();
            List<Space> threatened_spaces = new List<Space>();
            List<Space> king_threateners = new List<Space>();
            List<Piece> threat_pieces = new List<Piece>();

            Space king_space = new Space();
            king_space.ContainsPiece = false;

            //Locate king's space
            for (int i = 0; i < Board.Count; i++)
            {
                if (Board[i].ContainsPiece && Board[i].CurrentPiece.Name == "King" && Board[i].CurrentPiece.Side == turn) { king_space = Board[i]; }
            }

            //If a king is not found, return false
            if (!king_space.ContainsPiece) { return false; }

            //Create a list of spaces the king could run to (within one tile that are empty or contain an opposing piece)
            for (int i = 0; i < Board.Count; i++)
            {
                if (Math.Abs(Board[i].X - king_space.X) <= 1 && Math.Abs(Board[i].Y - king_space.Y) <= 1)
                {
                    if (!Board[i].ContainsPiece) { target_spaces.Add(Board[i]); }
                    else if (Board[i].ContainsPiece && Board[i].CurrentPiece.Side != turn) { target_spaces.Add(Board[i]); }
                    else if (Board[i] == king_space) { target_spaces.Add(Board[i]); }
        }
            }

            //Check to see which of the previous spaces are threatened by opposing pieces
            for (int i = 0; i < Board.Count; i++)
            {
                if (Board[i].ContainsPiece && Board[i].CurrentPiece.Side != turn)
                {
                    Space threat_space = Board[i];
                    Piece threat_piece = Board[i].CurrentPiece;
                    for (int j = 0; j < target_spaces.Count; j++)
                    {
                        if (threat_piece.is_Valid_Move(threat_space, target_spaces[j]) && !threat_piece.will_Collide(Board, threat_space, target_spaces[j]) && !threatened_spaces.Contains(target_spaces[j]))
                        {
                            threatened_spaces.Add(target_spaces[j]);
                            if (target_spaces[j] == king_space) { king_threateners.Add(threat_space); }
                        }
                    }
                }
            }

            //Check to see if the king's space and all surrounding spaces are threatened. Note that because we did not add duplicate spaces to threatened_spaces and restricted the add loop to the size of target_spaces, the following condition holds.
            if (target_spaces.Count == threatened_spaces.Count)
            {
                can_run = false;

                //If the king cannot run, the only remaining ways out are attacking or blocking any piece that currently threatens the king.
                //Note that you cannot block or attack two opposing pieces with one move. So:
                if (king_threateners.Count > 1) { return true; }
            }

            if (!can_run)
            {
                //Check to see if the piece that threatens the king can be attacked. Note that, if the king can't run, the only remaining possibility that doesn't return a value is that exactly one piece threatens the king.
                for (int i = 0; i < Board.Count; i++)
                {
                    if (Board[i].ContainsPiece && Board[i].CurrentPiece.Side == turn)
                    {
                        Space threat_space = Board[i];
                        Piece threat_piece = Board[i].CurrentPiece;
                        if (threat_piece.is_Valid_Move(threat_space, king_threateners[0]) && !threat_piece.will_Collide(Board, threat_space, king_threateners[0])) { can_attack = false; break; }
                    }
                }

                if (!can_attack)
                {
                    if (king_threateners[0].CurrentPiece.Name == "Knight") { can_block = false; return true; }
                    
                    List<Space> possible_blocks = king_threateners[0].CurrentPiece.Path(Board, king_threateners[0], king_space);

                    //Check to see if the piece that threatens the king can be blocked.
                    for (int i = 0; i < Board.Count; i++)
                    {
                        if (Board[i].ContainsPiece && Board[i].CurrentPiece.Side == turn)
                        {
                            Space threat_space = Board[i];
                            Piece threat_piece = Board[i].CurrentPiece;
                            for (int j = 0; j < possible_blocks.Count; j++)
                            {
                                if (threat_piece.is_Valid_Move(threat_space, possible_blocks[j]) && !threat_piece.will_Collide(Board, threat_space, possible_blocks[j])) { can_block = false; break; }
                            }
                            if (!can_block) { break; }
                        }
                    }

                    if (!can_block)
                    {
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            else { return false; }
        }

        //MAIN PROGRAM
        static void Main(string[] args)
        {
            bool New_Game = true;

            string player1 = "";
            string player2 = "";
            string turn = "";
            List<Space> Board = new List<Space>();
            List<Piece> Captured_Pieces = new List<Piece>();

            bool check = false;
            bool checkmate = false;

            while (true)
            {
                if (New_Game)
                {
                    //Define Players
                    Console.WriteLine("Player 1 (White), what is your name?");
                    player1 = Console.ReadLine();
                    Console.WriteLine("Player 2 (Black), what is your name?");
                    player2 = Console.ReadLine();

                    turn = "White"; //White moves first.

                    //Construct Board
                    Board = Starting_Board();
                    Captured_Pieces = new List<Piece>();

                    New_Game = false;
                }

                //Display board
                Display_Board(Board, Captured_Pieces);

                //Check for check (heh)
                check = Check(Board, turn);

                //Check for checkmate
                checkmate = Checkmate(Board, turn);

                //Take turn (Choose initial space and target space, check for invalid inputs along the way)
                if (turn == "White")
                {
                    Console.Write(player1 + ", it's your turn!");
                    if (checkmate) { Console.Write(" Oh no, you're in checkmate! Make your final move..."); }
                    else if (check) { Console.Write(" Careful, your king is in check!"); }
                    Console.WriteLine();
                }
                else if (turn == "Black") {
                    Console.Write(player2 + ", it's your turn!");
                    if (checkmate) { Console.Write(" Oh no, you're in checkmate! Make your final move..."); }
                    else if (check) { Console.Write(" Careful, your king is in check!"); }
                    Console.WriteLine();
                }
                else { break; }

                Piece selected_piece = new Piece();
                Space initial_space = new Space();
                Space target_space = new Space();

                //Ask for initial space, check validity
                bool valid_initial = false;
                while (!valid_initial)
                {
                    valid_initial = true;

                    Console.WriteLine("Please enter the X coordinate of the piece you want to move:");
                    string initial_x = Console.ReadLine();
                    Console.WriteLine("Please enter the Y coordinate of the piece you want to move:");
                    string initial_y = Console.ReadLine();
                    Console.WriteLine();

                    bool x_is_number = int.TryParse(initial_x, out int x);
                    bool y_is_number = int.TryParse(initial_y, out int y);
                    Space space = new Space();

                    if (!x_is_number) { Console.WriteLine("The space you have selected is invalid."); valid_initial = false; }
                    else if (!y_is_number) { Console.WriteLine("The space you have selected is invalid."); valid_initial = false; }
                    else if (x < 0 || x > 7) { Console.WriteLine("The space you have selected is out of bounds."); valid_initial = false; }
                    else if (y < 0 || y > 7) { Console.WriteLine("The space you have selected is out of bounds."); valid_initial = false; }

                    if (valid_initial)
                    {
                        space = Board[x + 8 * y];
                        if (!space.ContainsPiece) { Console.WriteLine("The space you have selected is empty."); valid_initial = false; }
                        else if (space.ContainsPiece && space.CurrentPiece.Side != turn) { Console.WriteLine("The space you have selected contains an opposing piece."); valid_initial = false; }
                    }

                    if (valid_initial)
                    {
                        selected_piece = space.CurrentPiece;
                        initial_space = space;
                    }
                }

                //Ask for target space, check validity
                bool valid_target = false;
                while (!valid_target)
                {
                    valid_target = true;

                    Console.WriteLine("Please enter the X coordinate of the space you want to move the " + selected_piece.Side + " " + selected_piece.Name + " to:");
                    string target_x = Console.ReadLine();
                    Console.WriteLine("Please enter the Y coordinate of the space you want to move the " + selected_piece.Side + " " + selected_piece.Name + " to:");
                    string target_y = Console.ReadLine();
                    Console.WriteLine();

                    bool x_is_number = int.TryParse(target_x, out int x);
                    bool y_is_number = int.TryParse(target_y, out int y);
                    Space space = new Space();

                    if (!x_is_number) { Console.WriteLine("The space you have selected is invalid."); valid_target = false; }
                    else if (!y_is_number) { Console.WriteLine("The space you have selected is invalid."); valid_target = false; }
                    else if (x < 0 || x > 7) { Console.WriteLine("The space you have selected is out of bounds."); valid_target = false; }
                    else if (y < 0 || y > 7) { Console.WriteLine("The space you have selected is out of bounds."); valid_target = false; }

                    if (valid_target)
                    {
                        space = Board[x + 8 * y];
                        if (space.X == initial_space.X && space.Y == initial_space.Y ) { Console.WriteLine("The space you have selected is the initial location."); valid_target = false; }
                        else if (space.ContainsPiece && space.CurrentPiece.Side == turn) { Console.WriteLine("The space you have selected contains one of your own pieces."); valid_target = false; }
                    }

                    //Check if the target can be reached under the movement rules for the piece
                    if (valid_target)
                    {
                        if (!selected_piece.is_Valid_Move(initial_space, space)) { Console.WriteLine("The space you have selected can't be reached by a " + selected_piece.Name + "."); valid_target = false; }
                    }

                    //Check for collision during movement (Not necessary for the knight, who can jump over pieces, or for the king, who doesn't have valid moves that could put him past other pieces.)
                    //Note that, by this point, we have already verified that the move is a legal move and is targeting an empty space or an opposing piece.
                    if (valid_target)
                    {
                        if (selected_piece.will_Collide(Board, initial_space, space)) { Console.WriteLine("The path to the space you have selected is blocked by other pieces."); valid_target = false; }
                    }

                    //If target space survives all validity checks, assign it
                    if (valid_target)
                    {
                        target_space = space;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have failed to enter a valid target space. Press any key to start your turn over.");
                        Console.ReadKey();
                        //This break is required; if the target space request loops like the initial space request, the program enters an infinite loop if the piece has no valid space to move to, i.e. a king in the starting position.
                        break;
                    }
                }

                //Update board and captured pieces list
                if (valid_initial && valid_target)
                {
                    int initial_index = initial_space.X + 8 * initial_space.Y;
                    int target_index = target_space.X + 8 * target_space.Y;

                    if (target_space.ContainsPiece) { Captured_Pieces.Add(target_space.CurrentPiece); }
                    selected_piece.HasMoved = true;
                    Board[target_index].CurrentPiece = selected_piece;
                    Board[target_index].ContainsPiece = true;
                    Board[initial_index].CurrentPiece = new Piece();
                    Board[initial_index].ContainsPiece = false;

                    //Check for promotion
                    if (selected_piece.Name == "Pawn" && turn == "White" && target_space.Y == 7)
                    {
                        string ans = "";
                        bool valid_ans = false;
                        Console.WriteLine("Congratulations on the promotion, " + player1 + "! What will your pawn become? (Choose Bishop/Knight/Rook/Queen, please captialize.)");

                        while (!valid_ans)
                        {
                            ans = Console.ReadLine();
                            if (ans == "Bishop") { Board[target_index].CurrentPiece = new Piece("White", "Bishop", "WB"); valid_ans = true; }
                            else if (ans == "Knight") { Board[target_index].CurrentPiece = new Piece("White", "Knight", "WN"); valid_ans = true; }
                            else if (ans == "Rook") { Board[target_index].CurrentPiece = new Piece("White", "Rook", "WR"); valid_ans = true; }
                            else if (ans == "Queen") { Board[target_index].CurrentPiece = new Piece("White", "Queen", "WQ"); valid_ans = true; }
                            else { Console.WriteLine("Invalid piece. Choose Bishop/Knight/Rook/Queen, please captialize."); }
                        }
                    }
                    else if (selected_piece.Name == "Pawn" && turn == "Black" && target_space.Y == 0)
                    {
                        string ans = "";
                        bool valid_ans = false;
                        Console.WriteLine("Congratulations on the promotion, " + player2 + "! What will your pawn become? (Choose Bishop/Knight/Rook/Queen, please captialize.)");

                        while (!valid_ans)
                        {
                            ans = Console.ReadLine();
                            if (ans == "Bishop") { Board[target_index].CurrentPiece = new Piece("Black", "Bishop", "BB"); valid_ans = true; }
                            else if (ans == "Knight") { Board[target_index].CurrentPiece = new Piece("Black", "Knight", "BN"); valid_ans = true; }
                            else if (ans == "Rook") { Board[target_index].CurrentPiece = new Piece("Black", "Rook", "BR"); valid_ans = true; }
                            else if (ans == "Queen") { Board[target_index].CurrentPiece = new Piece("Black", "Queen", "BQ"); valid_ans = true; }
                            else { Console.WriteLine("Invalid piece. Choose Bishop/Knight/Rook/Queen, please captialize."); }
                        }
                    }

                    //Check for winners
                    bool win = false;

                    for (int i = 0; i < Captured_Pieces.Count; i++)
                    {
                        if (Captured_Pieces[i].Name == "King") { win = true; }
                    }

                    if (win)
                    {
                        Display_Board(Board, Captured_Pieces);
                        if (turn == "White") { Console.WriteLine("Congratulations, " + player1 + "! You win!"); }
                        else if (turn == "Black") { Console.WriteLine("Congratulations, " + player2 + "! You win!"); }
                        else { break; }

                        string ans = "";
                        while (ans != "y" && ans != "Y" && ans != "n" && ans != "N")
                        {
                            Console.WriteLine("Play again? Y/N");
                            ans = Console.ReadLine();
                        }

                        if (ans == "n" || ans == "N")
                        {
                            break;
                        }
                        else if (ans == "y" || ans == "Y")
                        {
                            Console.WriteLine();
                            New_Game = true;
                        }
                    }

                    //Update turn
                    if (turn == "White") { turn = "Black"; }
                    else if (turn == "Black") { turn = "White"; }
                    else { break; }
                }
            }
        
        }
    }
}
