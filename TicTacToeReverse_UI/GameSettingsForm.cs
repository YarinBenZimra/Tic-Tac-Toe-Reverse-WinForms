using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeReverse_UI
{
    public partial class GameSettingsForm : Form
    {
        public const string k_Player1Name = "Player 1:";
        public const string k_Player2Name = "Player 2:";
        public const string k_ComputerGameplayName = "Computer:";
        public const string k_DefaultComputerNameWhenDisable = "[Computer]";

        public GameSettingsForm()
        {
            InitializeComponentGameSettingsForm();
        }
        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayer2.Checked)
            {
                textBoxPlayer2.Enabled = true;
                textBoxPlayer2.BackColor = Color.White;
                textBoxPlayer2.ForeColor = SystemColors.WindowText;
                textBoxPlayer2.Text = string.Empty;
            }
            else
            {
                textBoxPlayer2.Enabled = false;
                textBoxPlayer2.BackColor = SystemColors.ControlLight;
                textBoxPlayer2.ForeColor = SystemColors.GrayText;
                textBoxPlayer2.Text = k_DefaultComputerNameWhenDisable;
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            GamePlay gamePlay;
            int boardSize = Convert.ToInt32(numericUpDownCols.Value);
            if (checkBoxPlayer2.Checked)
            {
                gamePlay = new GamePlay(boardSize, true, k_Player2Name);
            }
            else
            {
                gamePlay = new GamePlay(boardSize, false, k_ComputerGameplayName);
            }
        }
        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCols.Value = numericUpDownRows.Value;
        }
        private void numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRows.Value = numericUpDownCols.Value;
        }
    }
}
