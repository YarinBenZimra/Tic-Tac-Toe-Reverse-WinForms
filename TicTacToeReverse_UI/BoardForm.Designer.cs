using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TicTacToeReverse_UI
{
    partial class BoardForm
    {
        private System.ComponentModel.IContainer components = null;
        private void InitializeComponentBoardForm(string i_Player2Name, int i_BoardLineSize)
        {
            int tabIndex;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BoardForm));
            TableLayoutPanel tableLayoutPanel = InitializeTableLayoutProperties(i_BoardLineSize);
            InitializeButtonsProperties(tableLayoutPanel, out tabIndex, i_BoardLineSize);
            InitializeLabelsProperties(tabIndex, i_Player2Name);
            InitializeFormProperties(tableLayoutPanel, resources);
        }
        private void InitializeFormProperties(TableLayoutPanel io_TableLayoutPanel, ComponentResourceManager i_Resources)
        {
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 545);
            Controls.Add(m_LabelPlayer1NameAndScore);
            Controls.Add(m_LabelPlayer2NameAndScore);
            Controls.Add(io_TableLayoutPanel);
            Name = "BoardForm";
            Text = "TicTacToeMisere";
            Icon = ((System.Drawing.Icon)(i_Resources.GetObject("$this.Icon")));
            ShowInTaskbar = true;
            StartPosition = FormStartPosition.CenterScreen;
            KeyDown += BoardForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }
        private TableLayoutPanel InitializeTableLayoutProperties(int i_BoardLineSize)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                            | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            tableLayoutPanel.ColumnCount = i_BoardLineSize;
            tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel.Size = new System.Drawing.Size(595, 500);
            for (int i = 0; i < i_BoardLineSize; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(100 / (i_BoardLineSize))));
                tableLayoutPanel.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, (float)(100 / (i_BoardLineSize))));
            }

            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            SuspendLayout();

            return tableLayoutPanel;
        }
        private void InitializeButtonsProperties(TableLayoutPanel io_TableLayoutPanel, out int io_TabIndex, int i_BoardLineSize)
        {
            int x = 3, y = 3, buttonIndex = 1;
            io_TabIndex = 1;
            for (int row = 0; row < i_BoardLineSize; row++)
            {
                for (int column = 0; column < i_BoardLineSize; column++, buttonIndex++, io_TabIndex += 10)
                {
                    BoardButton boardButton = new BoardButton();
                    boardButton.InitializeBoardButtonProperties(row, column, x, y, io_TabIndex, buttonIndex);
                    io_TableLayoutPanel.Controls.Add(boardButton, column, row);
                    x += 148;
                    m_Buttons.Add(boardButton);
                    boardButton.TabStop = false;
                }

                x = 3;
                y += 125;
            }
        }
        private void InitializeLabelsProperties(int i_TabIndex, string i_Player2Name)
        {
            m_LabelPlayer1NameAndScore = new Label();
            m_LabelPlayer1NameAndScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            m_LabelPlayer1NameAndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            m_LabelPlayer1NameAndScore.Location = new System.Drawing.Point(170, 518);
            m_LabelPlayer1NameAndScore.Name = "labelPlayer1NameAndScore";
            m_LabelPlayer1NameAndScore.Size = new System.Drawing.Size(152, 23);
            m_LabelPlayer1NameAndScore.TabIndex = i_TabIndex;
            m_LabelPlayer1NameAndScore.Text = "Player 1: 0";
            m_LabelPlayer2NameAndScore = new Label();
            m_LabelPlayer2NameAndScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            m_LabelPlayer2NameAndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            m_LabelPlayer2NameAndScore.Location = new System.Drawing.Point(330, 518);
            m_LabelPlayer2NameAndScore.Name = "labelPlayer2NameAndScore";
            m_LabelPlayer2NameAndScore.Size = new System.Drawing.Size(152, 23);
            i_TabIndex += 10;
            m_LabelPlayer2NameAndScore.TabIndex = i_TabIndex;
            m_LabelPlayer2NameAndScore.Text = i_Player2Name + " 0";
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}