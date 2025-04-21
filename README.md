# Jogo Breakout

This repository contains the source code for the "Jogo Breakout" project, a game developed using C# and Windows Forms.


## Key Files

- **`Form1.cs`**: Contains the main game logic and UI components.
- **`BDjogoDataSet.Designer.cs`**: Auto-generated code for managing the dataset and database interactions.
- **`Program.cs`**: Entry point of the application.
- **`Properties/Resources.resx`**: Resource file for managing localized strings and assets.

## How to Build and Run

1. Open the solution file `Jogo Breakout.sln` in Visual Studio.
2. Build the project using the `Debug` or `Release` configuration.
3. Run the application to play the game.

## Dependencies

- .NET Framework 4.7.2
- Windows Media Player Interop (`AxInterop.WMPLib.dll` and `Interop.WMPLib.dll`)

## Database

The project uses a local SQL Server database:
- **`BD.mdf`**: Main database file.
- **`BD_log.ldf`**: Log file for the database.

Ensure SQL Server is installed and configured to use these files.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
