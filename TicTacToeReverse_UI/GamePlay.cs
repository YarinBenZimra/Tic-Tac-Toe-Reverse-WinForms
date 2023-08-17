using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToeReverse_Logics;

namespace TicTacToeReverse_UI
{
    public class GamePlay
    {
        private bool          v_IsPlayer1Turn = true;
        private bool          v_IsMultiplayGame = false;
        private bool          v_IsEndGame = false;
        private BoardForm     m_BoardForm;
        private Player        m_Player1 = null;
        private Player        m_Player2 = null;
        private ComputerMoves m_ComputerMoves = null;
        private int           m_BoardLineSize;
        private Board         m_Board;

        public bool IsPlayer1Turn
        {
            get { return v_IsPlayer1Turn; }
            set { v_IsPlayer1Turn = value; }
        }
        public bool IsMultiplayGame
        {
            get { return v_IsMultiplayGame; }
            set { v_IsMultiplayGame = value; }
        }
        public bool IsEndOfGame
        {
            get { return v_IsEndGame; }
            set { v_IsEndGame = value; }
        }
        public BoardForm FormBoard
        {
            get { return m_BoardForm; }
        }
        public Player Player1
        {
            get { return m_Player1; }
        }
        public Player Player2
        {
            get { return m_Player2; }
        }
        public ComputerMoves Computer
        {
            get { return m_ComputerMoves; }
        }
        public int BoardLineSize
        {
            get { return m_BoardLineSize; }
            set { m_BoardLineSize = value; }
        }
        public Board GameBoard
        {
            get { return m_Board; }
        }

        public GamePlay(int i_BoardLineSize, bool i_IsMultiplayGame, string i_Player2Name)
        {
            m_BoardForm = new BoardForm(i_BoardLineSize, i_Player2Name);
            AddListenerToButtonClickEvent();
            InitiazlizePlayersForGame(i_IsMultiplayGame);
            m_Board = new Board((Byte)i_BoardLineSize);
            m_BoardLineSize = i_BoardLineSize;
            m_BoardForm.ShowDialog();
        }
        public void InitiazlizePlayersForGame(bool i_IsMultiplayGame)
        {
            if (i_IsMultiplayGame)
            {
                v_IsMultiplayGame = true;
                m_Player1 = new Player(1, Board.k_Xcharacter);
                m_Player2 = new Player(2, Board.k_Ocharacter);
            }
            else
            {
                m_Player1 = new Player(1, Board.k_Xcharacter);
                m_ComputerMoves = new ComputerMoves();
            }
        }
        public void AddListenerToButtonClickEvent()
        {
            List<BoardButton> buttons = m_BoardForm.BoardButtons;
            foreach (BoardButton boardButton in buttons)
            {
                boardButton.Click += GamePlayTurn;
            }
        }
        public void PlayerTurn(Board io_Board, int i_BoardButtonRow, int i_BoardButtonColumn)
        {
            if (v_IsMultiplayGame)
            {
                if (v_IsPlayer1Turn)
                {
                    m_Player1.MakeMove(io_Board, i_BoardButtonRow, i_BoardButtonColumn);
                }
                else
                {
                    m_Player2.MakeMove(io_Board, i_BoardButtonRow, i_BoardButtonColumn);
                }
            }
            else
            {
                m_Player1.MakeMove(io_Board, i_BoardButtonRow, i_BoardButtonColumn);
                io_Board.EmptyCells.RemoveAll((Tuple<int, int> cell) => cell.Item1 == (i_BoardButtonRow - 1) && cell.Item2 == (i_BoardButtonColumn - 1));
            }
        }
        public BoardButton ComputerTurn(Board io_Board, int i_BoardLineSize, List<BoardButton> i_Buttons)
        {
            m_ComputerMoves.ComputerTurn(io_Board);
            Tuple<int, int> currentRandomSelectedCell = m_ComputerMoves.CurrentRandomSelectedCell;
            int buttonLocation = (currentRandomSelectedCell.Item1 * i_BoardLineSize) + currentRandomSelectedCell.Item2;
            BoardButton button = i_Buttons[buttonLocation];

            return button;
        }
        private void GamePlayTurn(object sender, EventArgs e)
        {
            BoardButton boardButton = sender as BoardButton;
            m_BoardForm.UpdateButtonAndLabelsProperties(boardButton, v_IsPlayer1Turn, v_IsMultiplayGame);
            BoardMovement(boardButton);
        }
        public void BoardMovement(BoardButton boardButton)
        {
            v_IsEndGame = false;
            if (v_IsMultiplayGame)
            {
                PlayerTurn(m_Board, boardButton.RowInBoard + 1, boardButton.ColumnInBoard + 1);
                IsEndGame();
            }
            else
            {
                PlayerTurn(GameBoard, boardButton.RowInBoard + 1, boardButton.ColumnInBoard + 1);
                IsEndGame();
                if (!v_IsEndGame)
                {
                    BoardButton nextChosenBoardButton = ComputerTurn(GameBoard, BoardLineSize, m_BoardForm.BoardButtons);
                    nextChosenBoardButton.Text = BoardForm.k_Ocharacter;
                    nextChosenBoardButton.Enabled = false;
                    IsEndGame();
                }
            }
        }
        public DialogResult AddScoreAndAnnounceWinner()
        {
            string winnerMessage = null;
            if (v_IsMultiplayGame)
            {
                if (v_IsPlayer1Turn)
                {
                    winnerMessage = GameMessages.k_Player2WinMessage;
                    m_Player2.NumberOfWins++;
                    m_BoardForm.LabelPlayer2NameAndScore.Text = GameSettingsForm.k_Player2Name + m_Player2.NumberOfWins.ToString();
                }
                else
                {
                    winnerMessage = GameMessages.k_Player1WinMessage;
                    m_Player1.NumberOfWins++;
                    m_BoardForm.LabelPlayer1NameAndScore.Text = GameSettingsForm.k_Player1Name + m_Player1.NumberOfWins.ToString();
                }
            }
            else
            {
                if (v_IsPlayer1Turn)
                {
                    winnerMessage = GameMessages.k_ComputerWinMessage;
                    m_ComputerMoves.NumberOfWins++;
                    m_BoardForm.LabelPlayer2NameAndScore.Text = GameSettingsForm.k_ComputerGameplayName + m_ComputerMoves.NumberOfWins.ToString();
                }
                else
                {
                    winnerMessage = GameMessages.k_Player1WinMessage;
                    m_Player1.NumberOfWins++;
                    m_BoardForm.LabelPlayer1NameAndScore.Text = GameSettingsForm.k_Player1Name + m_Player1.NumberOfWins.ToString();
                }
            }

            return MessageBox.Show(String.Format(winnerMessage), GameMessages.k_WinTitle, MessageBoxButtons.YesNo);
        }
        public void IsEndGame()
        {
            DialogResult anotherGame = DialogResult.OK;
            if (m_Board.HasSequence == 1)
            {
                anotherGame = AddScoreAndAnnounceWinner();
                MessageBoxResultEventHandler(anotherGame);
                v_IsEndGame = true;
            }
            else if (m_Board.IsBoardFull())
            {
                anotherGame = MessageBox.Show(String.Format(GameMessages.k_TieMessage), GameMessages.k_TieTitle, MessageBoxButtons.YesNo);
                MessageBoxResultEventHandler(anotherGame);
                v_IsEndGame = true;
            }
            else
            {
                v_IsPlayer1Turn = !v_IsPlayer1Turn; // The game continues to the next opponent
            }
        }
        public void MessageBoxResultEventHandler(DialogResult i_AnotherGame)
        {
            if (i_AnotherGame == DialogResult.Yes)
            {
                InitializeBoardForNewGame();
            }
            else
            {
                m_BoardForm.Close();
            }
        }
        public void InitializeBoardForNewGame()
        {
            m_BoardForm.ClearBoard();
            m_Board = new Board((Byte)m_BoardLineSize);
            v_IsPlayer1Turn = true;
        }
    }
}
