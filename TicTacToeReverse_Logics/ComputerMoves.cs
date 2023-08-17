
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace TicTacToeReverse_Logics
{
    public class ComputerMoves
    {
        private int m_NumberOfWins;
        private Tuple<int, int> m_CurrentRandomSelectedCell;

        public int NumberOfWins
        {
            get { return m_NumberOfWins; }
            set { m_NumberOfWins = value; }
        }
        public Tuple<int, int> CurrentRandomSelectedCell
        {
            get { return m_CurrentRandomSelectedCell; }
            set { m_CurrentRandomSelectedCell = value; }
        }

        public void MakeMove(Board i_Board, int i_Row, int i_Column)
        {
            CurrentRandomSelectedCell = Tuple.Create(i_Row - 1, i_Column - 1);
            i_Board.Table[i_Row - 1, i_Column - 1] = Board.k_Ocharacter;
            i_Board.AddOToDataStructures(i_Row, i_Column);
            i_Board.CountFullCells++;
        }
        public void ComputerTurn(Board io_Board)
        {
            Random random = new Random();
            int numOfRows = io_Board.GetMatrix().GetLength(0) + 1, row = 0, column = 0;
            Tuple<int, int> selectedCell = io_Board.EmptyCells[random.Next(io_Board.EmptyCells.Count)];
            row = selectedCell.Item1;
            column = selectedCell.Item2;
            io_Board.EmptyCells.RemoveAll(cell => cell.Item1 == row && cell.Item2 == column);
            MakeMove(io_Board, row + 1, column + 1);
        }
    }

}





