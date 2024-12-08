# Reversed Tic-Tac-Toe for Windows

Welcome to **Reversed Tic-Tac-Toe**! This project is a Windows Forms application that reimagines the classic Tic-Tac-Toe game with an intuitive graphical user interface (GUI). The application allows users to play against another player or challenge a computer opponent while offering custom game settings and real-time feedback.

---

## Table of Contents

- [Project Overview](#project-overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation and Setup](#installation-and-setup)
- [How to Use](#how-to-use)
- [Design and Implementation](#design-and-implementation)
- [Contribution and Support](#contribution-and-support)
---

## Project Overview

The **Reversed Tic-Tac-Toe** application is designed to provide a seamless gaming experience with customizable settings and multiple game modes. Players can enjoy a competitive two-player game or challenge a computer opponent with dynamic moves. The system ensures a polished user interface and engaging gameplay.

---

## Features

1. **Game Modes**:
   - **2 Players**: Two human players take turns.
   - **Player vs. Computer**: Compete against a computer with automated moves.

2. **Settings Window**:
   - Configure the board size (rows and columns).
   - Enter player names and select game mode.

3. **Interactive Game Board**:
   - A matrix of buttons represents the game grid.
   - Visual feedback for each move.

4. **Outcome Messages**:
   - Display the winner or indicate a tie with a message box.
   - Prompt to start a new game after the current one ends.

5. **Game Logic**:
   - Check win conditions.
   - Reset the game seamlessly for a new round.

---

## Prerequisites

Ensure you have the following installed:
- **Visual Studio** (recommended for building the project).
- **.NET Framework/SDK**.
- **Git** (for cloning the repository).

---

## Installation and Setup

### Step 1: Clone the Repository

Clone the project using the following command:

```bash
git clone https://github.com/YarinBenZimra/Tic-Tac-Toe-Reverse-WinForms.git
```

### Step 2: Open and Build the Project

1. Navigate to the project folder:
   ```bash
   cd Tic-Tac-Toe-Reverse-WinForms
   ```

2. Open the solution file:
   - Double-click `Tic-Tac-Toe-Reverse WinForms.sln` to open the project in Visual Studio.

3. Build the solution:
   - Go to the **Build** menu and select **Build Solution** (or press `Ctrl + Shift + B`).

4. Start the project:
   - Press `F5` to run the application.

---

## How to Use

1. **Launch the Application**:
   - The settings window will appear first.

2. **Configure Game Settings**:
   - Select the game mode:
     - **2 Players** for a traditional two-player game.
     - **Player vs. Computer** to play against the computer.
   - Enter the player's name (if applicable).
   - Configure the board size (rows and columns).

3. **Play the Game**:
   - Click the **Start!** button to open the game board.
   - Players take turns clicking buttons on the board to place their symbols (X or O).

4. **Game Outcome**:
   - A message box will display the result (winner or tie).
   - Choose to start a new game or exit the application.

---

## Design and Implementation

### Project Structure

#### Logic Layer (`TicTacToeReverse_Logics`)
- **`Board.cs`**: Handles the board's state and operations.
- **`ComputerMoves.cs`**: Implements the logic for computer moves.
- **`Player.cs`**: Manages player details and actions.
- **`TicTacToeReverse_Logics.cs`**: Entry point for core game logic.

#### UI Layer (`TicTacToeReverse_UI`)
- **`BoardForm.cs`**: Main form for the game board.
- **`GameSettingsForm.cs`**: Form for configuring game settings.
- **`BoardButton.cs`**: Represents individual buttons on the game board.
- **`GamePlay.cs`**: Manages gameplay mechanics and interactions.
- **`GameMessages.cs`**: Handles game outcome messages and prompts.
- **`Program.cs`**: Application entry point.

### Key Design Concepts
1. **Windows Forms**:
   - Simplifies GUI creation with drag-and-drop components and event handlers.
2. **Event Handling**:
   - Button clicks trigger updates to the board and game logic.
3. **Layered Architecture**:
   - Separation of UI and logic ensures maintainability.
4. **Customizable Board**:
   - Users can define board size to increase replayability.

---

## Contribution and Support

Contributions, bug reports, and feature suggestions are welcome! Submit pull requests or open issues on the GitHub repository.
---

Enjoy playing **Reversed Tic-Tac-Toe**! 🎮
