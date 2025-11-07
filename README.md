# Chess Game Application

A fully functional Chess game built in C# using .NET 8.0, featuring a clean WPF user interface and a robust chess logic library.

## Overview

This application provides a complete chess experience with standard rules, including special moves like castling, en passant, and pawn promotion. The project is divided into two main components:

- **ChessLogic**: A class library containing all the chess game logic, rules, and state management.
- **ChessUI**: A WPF application providing the graphical user interface for playing the game.

## Features

- Complete chess rule implementation
- Special moves: Castling, En Passant, Pawn Promotion
- Check and Checkmate detection
- Game over conditions (Checkmate, Stalemate)
- Interactive WPF interface with drag-and-drop style piece movement
- Start, Pause, and Game Over menus
- Visual feedback for legal moves and check status
- Custom cursors for different players

## Prerequisites

- .NET 8.0 SDK
- Windows operating system (for WPF UI)
- Visual Studio 2022 or later (recommended)

## Installation

1. Clone the repository:
   ```
   git clone <repository-url>
   cd Chess
   ```

2. Open the solution file `Chess.sln` in Visual Studio.

3. Restore NuGet packages (if any):
   ```
   dotnet restore
   ```

4. Build the solution:
   ```
   dotnet build
   ```

## Usage

1. Run the ChessUI project from Visual Studio or use:
   ```
   dotnet run --project ChessUI/ChessUI.csproj
   ```

2. The start menu will appear. Click "Start" to begin a new game.

3. Click on a piece to select it, then click on a highlighted square to move.

4. Use the Escape key to pause the game.

5. The game handles all standard chess rules automatically.

## Project Structure

```
Chess/
├── Chess.sln                    # Visual Studio solution file
├── ChessLogic/                  # Chess logic library
│   ├── ChessLogic.csproj        # Project file
│   ├── Board.cs                 # Chess board representation
│   ├── GameState.cs             # Game state management
│   ├── Position.cs              # Position utilities
│   ├── Player.cs                # Player enumeration
│   ├── PieceType.cs             # Piece type enumeration
│   ├── Moves/                   # Move-related classes
│   │   ├── Move.cs              # Base move class
│   │   ├── NormalMove.cs        # Normal piece moves
│   │   ├── DoublePawn.cs        # Double pawn push
│   │   ├── Castle.cs            # Castling moves
│   │   ├── EnPassant.cs         # En passant captures
│   │   └── PawnPromotion.cs     # Pawn promotion moves
│   └── Pieces/                  # Piece-specific logic
│       ├── Piece.cs             # Base piece class
│       ├── Pawn.cs              # Pawn logic
│       ├── Rook.cs              # Rook logic
│       ├── Knight.cs            # Knight logic
│       ├── Bishop.cs            # Bishop logic
│       ├── Queen.cs             # Queen logic
│       └── King.cs              # King logic
├── ChessUI/                     # WPF user interface
│   ├── ChessUI.csproj           # Project file
│   ├── App.xaml                 # Application definition
│   ├── MainWindow.xaml          # Main game window
│   ├── MainWindow.xaml.cs       # Main window logic
│   ├── Assets/                  # Game assets (images, cursors)
│   ├── CheckMenu.xaml           # Check notification menu
│   ├── GameOverMenu.xaml        # Game over menu
│   ├── PauseMenu.xaml           # Pause menu
│   ├── PromotionMenu.xaml       # Pawn promotion selection
│   ├── StartMenu.xaml           # Start menu
│   └── ChessCursors.cs          # Custom cursor definitions
└── TODO.md                      # Development tasks
```

## Architecture

- **ChessLogic**: Contains all game logic, move validation, and state management. It's designed to be UI-agnostic, allowing for different interfaces (console, web, etc.).
- **ChessUI**: Implements the WPF interface, handling user input, displaying the board and pieces, and managing game flow.

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

## Acknowledgments

- Chess piece images and assets are included in the project
- Built with .NET 8.0 and WPF for modern Windows applications
