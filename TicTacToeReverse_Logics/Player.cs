using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToeReverse_Logics;

namespace TicTacToeReverse_Logics
{
    public class Player
    {
        public byte PlayerNumber { get; set; } // Player 1 or player 2
        public byte PlayerSymbol { get; set; } // X or O
        public int NumberOfWins { get; set; } // Number of wins

        public Player(byte i_PlayerNumber, byte i_PlayerSymbol)
        {
            PlayerSymbol = i_PlayerSymbol;
            PlayerNumber = i_PlayerNumber;
        }
        public void MakeMove(Board i_Board, int i_Row, int i_Column)
        {
            i_Board.Table[i_Row - 1, i_Column - 1] = PlayerSymbol;
            if (PlayerSymbol == 'X')
            {
                i_Board.AddXToDataStructures(i_Row, i_Column);
            }
            else
            {
                i_Board.AddOToDataStructures(i_Row, i_Column);
            }
            i_Board.CountFullCells++;

        }
    }
}
