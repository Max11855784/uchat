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

### Run from the terminal

Restore project dependencies:

```bash
dotnet restore
```

Start the server on port `5000`:

```bash
dotnet run --project uchat_server/uchat_server.csproj -- 5000
```

Keep this terminal window open. The server should display a message similar to:

```text
[OK] Server is running on port 5000
[OK] Waiting for clients...
```

Open another terminal window and start the WPF client:

```bash
dotnet run --project uchat_gui/uchat_gui.csproj
```

Alternatively, start the console client:

```bash
dotnet run --project uchat/uchat_client.csproj -- 127.0.0.1 5000
```

The console client requires two arguments:

```text
uchat_client <server_ip> <port>
```

Example:

```text
127.0.0.1 5000
```

The server must be running before any client connects.

---

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
