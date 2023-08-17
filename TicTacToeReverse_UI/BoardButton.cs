using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeReverse_UI
{
    public class BoardButton : Button
    {
        private int m_RowInBoard;
        private int m_ColumnInBoard;

        public int RowInBoard
        {
            get { return m_RowInBoard; }
        }
        public int ColumnInBoard
        {
            get { return m_ColumnInBoard; }
        }

        public void InitializeBoardButtonProperties(int i_RowInBoard, int i_ColumnInBoard, int i_BoardButtonLocationXCoordinate,
                                                     int i_BoardButtonLocationYCoordinate, int i_TabIndex, int i_ButtonIndex)
        {
            m_RowInBoard = i_RowInBoard;
            m_ColumnInBoard = i_ColumnInBoard;
            BackColor = System.Drawing.SystemColors.ControlLight;
            Dock = System.Windows.Forms.DockStyle.Fill;
            Location = new System.Drawing.Point(i_BoardButtonLocationXCoordinate, i_BoardButtonLocationYCoordinate);
            Name = "button" + i_ButtonIndex.ToString();
            TabIndex = i_TabIndex;
            Enabled = true;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            UseVisualStyleBackColor = false;
        }
    }
}
