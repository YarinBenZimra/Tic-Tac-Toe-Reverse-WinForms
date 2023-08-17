using System;
using System.Collections.Generic;

namespace TicTacToeReverse_Logics
{
    public class Board
    {
        public const byte    k_Xcharacter = 88;        // 'X'
        public const byte    k_Ocharacter = 79;       // 'O'
        public const byte    k_SpaceCharacter = 32;  // SPACE
        private const string k_invalidCellMessage = "Invalid Cell";
        private const string k_OccupiedCellMessage = "Occupied Cell";

        private List<XO_Symbols> Column { get; set; }
        private List<XO_Symbols> Row { get; set; }
        private List<XO_Symbols> Slant { get; set; }
        public List<Tuple<int, int>> EmptyCells { get; set; }
        public byte CountFullCells { get; set; }
        public byte[,] Table { get; }
        public byte HasSequence { get; set; }
        private class XO_Symbols
        {
            private byte m_Xsymbol;
            private byte m_Osymbol;
            public byte GetCountOfXsymbols()
            {
                return m_Xsymbol;
            }
            public byte AddXsymbolAndCheckForSequence(byte i_MatrixLength)
            {
                byte isXSequence = 0;

                m_Xsymbol++;

                if (m_Xsymbol == i_MatrixLength)
                {
                    isXSequence = 1;
                }

                return isXSequence;
            }
            public byte GetCountOfOsymbols()
            {
                return m_Osymbol;
            }
            public byte AddOsymbolAndCheckForSequence(byte i_MatrixLength)
            {
                byte isOSequence = 0;

                m_Osymbol++;

                if (m_Osymbol == i_MatrixLength)
                {
                    isOSequence = 1;
                }

                return isOSequence;
            }
        }

        public Board(byte i_Size)
        {
            Table = new byte[i_Size, i_Size];
            EmptyCells = new List<Tuple<int, int>>();

            for (int i = 0; i < i_Size; ++i)
            {
                for (int j = 0; j < i_Size; ++j)
                {
                    Table[i, j] = k_SpaceCharacter;
                    EmptyCells.Add(Tuple.Create(i, j));
                }
            }

            Column = new List<XO_Symbols>(i_Size);
            Row = new List<XO_Symbols>(i_Size);
            Slant = new List<XO_Symbols>(i_Size);

            for (int i = 0; i < i_Size; ++i)
            {
                Column.Add(new XO_Symbols());
                Row.Add(new XO_Symbols());
            }

            Slant.Add(new XO_Symbols());
            Slant.Add(new XO_Symbols());
        }
        public byte[,] GetMatrix()
        {
            return Table;
        }
        public void AddXToDataStructures(int i_Row, int i_Column)
        {
            byte ColumnLength = (byte)Column.Count;
            HasSequence |= Column[i_Column - 1].AddXsymbolAndCheckForSequence(ColumnLength);
            HasSequence |= Row[i_Row - 1].AddXsymbolAndCheckForSequence(ColumnLength);

            if (i_Row == i_Column)
            {
                HasSequence |= Slant[0].AddXsymbolAndCheckForSequence(ColumnLength);
            }
            if (i_Row + i_Column == Row.Count + 1)
            {
                HasSequence |= Slant[1].AddXsymbolAndCheckForSequence(ColumnLength);
            }
        }
        public void AddOToDataStructures(int i_Row, int i_Column)
        {
            byte ColumnLength = (byte)Column.Count;
            HasSequence |= Column[i_Column - 1].AddOsymbolAndCheckForSequence(ColumnLength);
            HasSequence |= Row[i_Row - 1].AddOsymbolAndCheckForSequence(ColumnLength);

            if (i_Row == i_Column)
            {
                HasSequence |= Slant[0].AddOsymbolAndCheckForSequence(ColumnLength);
            }
            if (i_Row + i_Column == Row.Count + 1)
            {
                HasSequence |= Slant[1].AddOsymbolAndCheckForSequence(ColumnLength);
            }
        }
        public bool IsBoardFull()
        {
            bool res = false;
            if (CountFullCells == Table.Length)
            {
                res = true;
            }

            return res;
        }
        public void isCellInRangeOrOccupied(int i_Row, int i_Column)
        {
            if ((i_Row <= 0 || i_Column <= 0)
                  || (i_Row > Row.Count || i_Column > Row.Count))
            {
                throw new Exception(k_invalidCellMessage);
            }
            else if (Table[i_Row - 1, i_Column - 1] != Board.k_SpaceCharacter)
            {
                throw new Exception(k_OccupiedCellMessage);
            }
        }
    }
}
