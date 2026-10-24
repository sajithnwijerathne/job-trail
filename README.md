# JobTrail

A cross-platform desktop app for tracking job applications, built with [Avalonia UI](https://avaloniaui.net/) and .NET.

> **Status:** early scaffolding — the project structure is in place, features are not yet implemented.

## Tech stack

- [.NET 10](https://dotnet.microsoft.com/)
- [Avalonia 12](https://avaloniaui.net/) with the Fluent theme
- [CommunityToolkit.Mvvm](https://learn.microsoft.com/dotnet/communitytoolkit/mvvm/) for the MVVM pattern
- [xUnit](https://xunit.net/) for tests

## Project structure

```
JobTrail.slnx            Solution file
JobTrail.App/            Avalonia desktop application
  Models/                Domain models
  ViewModels/            View models (MVVM)
  Views/                 XAML views
  Assets/                Icons and other resources
JobTrail.Tests/          xUnit test project
```

## Getting started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

### Build and run

```bash
dotnet build
dotnet run --project JobTrail.App
```

### Run tests

```bash
dotnet test
```

## Development

The repo includes VS Code launch and task configurations in `.vscode/`, so you can build and debug from VS Code with F5. Install the recommended extensions when prompted.
