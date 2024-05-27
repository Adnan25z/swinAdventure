# SwinAdventure

## Introduction
SwinAdventure is a command-line and GUI-based game developed using C# and WPF. The project is structured into three main parts: `Iteration1`, `SwinAdvGUI`, and `NUnitTests`. `Iteration1` demonstrates the core game mechanics using object-oriented programming principles in a command-line interface. `SwinAdvGUI` extends the functionality to a graphical user interface using WPF. `NUnitTests` provides unit tests for various functionalities to ensure code reliability and correctness.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Dependencies](#dependencies)
- [Detailed Code Analysis](#detailed-code-analysis)
  - [Overview](#overview)
  - [Code Structure](#code-structure)
  - [Key Components](#key-components)
  - [Object-Oriented Principles](#object-oriented-principles)
  - [Design Patterns](#design-patterns)
  - [Iteration1](#iteration1)
  - [SwinAdvGUI](#swinadvGUI)
  - [NUnitTests](#nunitTests)
- [Contributors](#contributors)

## Features
- **Command-Line Interface**: Core game mechanics using OOP principles.
- **Graphical User Interface**: Extended functionality using WPF.
- **Unit Testing**: Comprehensive unit tests for functionality verification.

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/Adnan25z/swinAdventure.git
2. Open the solution in Visual Studio.
3. Build the solution to restore dependencies.

## Usage
1. Run the command-line version from the Iteration1 folder.
2. Run the GUI version from the SwinAdvGUI folder.
3. Execute unit tests from the NUnitTests folder using the test explorer in Visual Studio.

## Dependencies
- .NET Framework
- WPF
- NUnit

## Detailed Code Analysis
### Overview
SwinAdventure is an educational project designed to demonstrate object-oriented programming (OOP) concepts and the application of design principles in game development. The project progresses from a command-line interface to a graphical user interface, showcasing the versatility and scalability of OOP.

### Code Structure
1. Iteration1: Command-line implementation of the game.
2. SwinAdvGUI: WPF-based graphical user interface.
3. NUnitTests: Unit tests for game functionality.

### Key Components
1. Game Classes: Core game logic and mechanics.
2. User Interface: CLI and GUI implementations.
3. Tests: NUnit test cases for verifying functionality.

### Object-Oriented Principles
1. Encapsulation
   - Usage: Encapsulation is achieved by defining private fields and providing public properties or methods to access them.
   - Examples:
     - Player class: Encapsulates player details and actions.
     - Inventory class: Encapsulates the collection of items.

2. Abstraction
   - Usage: Abstraction is used to hide complex implementation details and expose only the necessary functionalities.
   - Examples:
     - GameObject class: Provides a common interface for items and players.
     - Command class: Abstracts the execution of various game commands.

3. Inheritance
   - Usage: Inheritance promotes code reuse by creating a base class and deriving specific classes from it.
   - Examples:
     - Player and Item classes inherit from GameObject.
     - Command class serves as a base class for specific command implementations like LookCommand, MoveCommand.

4. Polymorphism
   - Usage: Polymorphism allows methods to be used interchangeably among different derived classes.
   - Examples:
     - Overriding methods in GameObject in derived classes like Player and Item.
     - Implementing the Execute method differently in each derived Command class.
       
### Design Patterns
- MVC Pattern: Used in SwinAdvGUI for separating concerns between the Model (game logic), View (UI), and Controller (user input).
- Singleton Pattern: Ensures that certain classes have only one instance throughout the application.
- Factory Pattern: Used for creating objects without specifying the exact class of object that will be created.

### Iteration1
The Iteration1 folder contains the initial version of the game implemented as a command-line application. It demonstrates fundamental OOP concepts such as classes, objects, inheritance, and polymorphism. Key files include GameObject.cs, Player.cs, Item.cs, and various command classes like LookCommand.cs and MoveCommand.cs.

### SwinAdvGUI
The SwinAdvGUI folder extends the command-line application to a WPF-based graphical user interface. This version utilizes the Model-View-Controller (MVC) pattern to separate the business logic from the UI. Key files include MainWindow.xaml and MainWindow.xaml.cs which define the GUI components and their interactions.

### NUnitTests
The NUnitTests folder contains unit tests for various components of the game. These tests ensure that the game logic is correct and that the application behaves as expected. Key test files include TestPlayer.cs, TestInventory.cs, TestCommandProcessor.cs, and others.

### Contributors
Adnan Zafar

