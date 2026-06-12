# uChat

**uChat** is a desktop client-server messenger built with C# and .NET. The project includes a TCP server, a WPF graphical client, and a console client.

The application supports user authentication, public and private messaging, chat rooms, message history, online users list, and file transfer.

---

## Features

- User registration and login
- Password hashing
- TCP client-server communication
- WPF desktop client
- Console client
- Public chat
- Private messages
- Chat rooms
- Message history
- Online users list
- Message editing and deletion
- File transfer between users
- SQLite storage on the server side

---

## Technology Stack

- C#
- .NET 8
- WPF
- TCP sockets
- SQLite
- Microsoft.Data.Sqlite

---

## Project Structure

```text
uchat/
├── uchat.sln
├── uchat/
│   ├── uchat_client.csproj
│   └── ...
├── uchat_gui/
│   ├── uchat_gui.csproj
│   └── ...
└── uchat_server/
    ├── uchat_server.csproj
    └── ...
```

---

## Requirements

Before running the project, install:

- .NET 8 SDK
- Visual Studio 2022 or another IDE with .NET support

---

## How to Run

### Option 1: Run with Visual Studio

1. Clone the repository:

```bash
git clone https://github.com/Max11855784/uchat.git
```

2. Open the solution file in Visual Studio:

```text
uchat.sln
```

3. Start the server project first:

```text
uchat_server
```

4. Start one or more client applications:

```text
uchat_gui
```

or

```text
uchat
```

The server must be running before clients connect.

---

### Option 2: Run from the terminal

Restore dependencies:

```bash
dotnet restore
```

Start the server:

```bash
dotnet run --project uchat_server/uchat_server.csproj
```

Then open another terminal window and start the WPF client:

```bash
dotnet run --project uchat_gui/uchat_gui.csproj
```

Alternatively, start the console client:

```bash
dotnet run --project uchat/uchat_client.csproj
```

The server should remain running while clients are connected.

## Educational Purpose

This project was created to practice:

- Client-server architecture
- TCP socket communication
- Desktop application development with WPF
- User authentication
- SQLite database integration
- Message handling
- File transfer logic
- Separation of client and server responsibilities

---

## Author

Maksym Rusanov
