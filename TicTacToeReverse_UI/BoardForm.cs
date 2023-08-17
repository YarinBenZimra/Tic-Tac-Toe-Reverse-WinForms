using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using TicTacToeReverse_Logics;
using TicTacToeReverse_UI;

namespace TicTacToeReverse_UI
{
    public partial class BoardForm : Form
    {
        public const string       k_Ocharacter = "O";
        public const string       k_Xcharacter = "X";
        private List<BoardButton> m_Buttons;
        private Label             m_LabelPlayer1NameAndScore = null;
        private Label             m_LabelPlayer2NameAndScore = null;

        public List<BoardButton> BoardButtons
        {
            get { return m_Buttons; }
        }
        public Label LabelPlayer1NameAndScore
        {
            get { return m_LabelPlayer1NameAndScore; }
            set { m_LabelPlayer1NameAndScore = value; }
        }
        public Label LabelPlayer2NameAndScore
        {
            get { return m_LabelPlayer2NameAndScore; }
            set { m_LabelPlayer2NameAndScore = value; }
        }

        public BoardForm(int i_BoardLineSize, string i_Player2Name)
        {
            m_Buttons = new List<BoardButton>(i_BoardLineSize * i_BoardLineSize);
            InitializeComponentBoardForm(i_Player2Name, i_BoardLineSize);
        }
        private void BoardForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                foreach (BoardButton boardButton in m_Buttons)
                {
                    boardButton.TabStop = true;
                }
            }
        }
        public void UpdateButtonAndLabelsProperties(BoardButton boardButton, bool i_IsPlayer1Turn, bool i_IsMultiplayGame)
        {
            if (i_IsPlayer1Turn)
            {
                boardButton.Text = k_Xcharacter;
                if (i_IsMultiplayGame)
                {
                    m_LabelPlayer1NameAndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    m_LabelPlayer2NameAndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            else
            {
                boardButton.Text = k_Ocharacter;
                m_LabelPlayer2NameAndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                m_LabelPlayer1NameAndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            boardButton.Enabled = false;
        }
        public void ClearBoard()
        {
            foreach (BoardButton boardButton in m_Buttons)
            {
                boardButton.Enabled = true;
                boardButton.Text = string.Empty;
                boardButton.TabStop = true;
            }

            m_LabelPlayer2NameAndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            m_LabelPlayer1NameAndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}

